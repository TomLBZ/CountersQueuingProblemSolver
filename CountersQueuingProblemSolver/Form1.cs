using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CountersQueuingProblemSolver
{
    public partial class Form1 : Form
    {
        private int timeStamp = 0;
        private CounterSystem cs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = cs.Update();
            txtTime.Text = timeStamp.ToString();
            txtPplNum.Text = cs.getCount().ToString();
            txtQ.Text = cs.getQbyLevel();
            txtYet.Text = cs.getNumYet().ToString();
            timeStamp++;
       }

        private int[] IntsFromStringArray(String[] array)
        {
            int[] ints = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                ints[i] = Convert.ToInt32(array[i]);
            }
            return ints;
        }

        private int[][] IntsArrayFromStringArray(String[] array)
        {
            int count = array.Length;
            List<int[]> lint = new List<int[]>();
            for (int i = 0; i < count; i++)
            {
                lint.Add(IntsFromStringArray(array[i].Split(',')));
            }
            return lint.ToArray();
        }

        private bool[][] BoolsArrFromIntsArr(int[][] input)
        {
            List<bool[]> lbool = new List<bool[]>();
            for (int i = 0; i < input.Length; i++)
            {
                int count = input[i].Length;
                bool[] b = new bool[count];
                for (int j = 0; j < count; j++)
                {
                    b[j] = input[i][j] == 0 ? false : true;
                }
                lbool.Add(b);
            }
            return lbool.ToArray();
        }

        private void Initialize()
        {
            timeStamp = 0;
            int comingTime = Convert.ToInt32(txtArrival.Text);
            int levelNum = Convert.ToInt32(txtLevels.Text);
            int totalStudents = Convert.ToInt32(txtNumStudent.Text);
            int[] levelCounters = IntsFromStringArray(txtLvlNum.Text.Split(','));
            int[] levelProccessTime = IntsFromStringArray(txtProcTime.Text.Split(','));
            int[][] systemInitialState = IntsArrayFromStringArray(txtIniState.Text.Split(';'));
            bool[][] iniState = BoolsArrFromIntsArr(systemInitialState);
            cs = new CounterSystem(levelNum, totalStudents, levelCounters, levelProccessTime, iniState, comingTime);
            txtTime.Text = "0";
            txtPplNum.Text = "0";
            txtQ.Text = "0";
            txtYet.Text = totalStudents.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
            txtPplNum.Text = cs.getCount().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnSimulateOnce_Click(object sender, EventArgs e)
        {
            cs.Update();
            txtTime.Text = timeStamp.ToString();
            txtPplNum.Text = cs.getCount().ToString();
            txtQ.Text = cs.getQbyLevel();
            txtYet.Text = cs.getNumYet().ToString();
            timeStamp++;
        }
    }

    public class Counter
    {
        private int processingTime;
        private bool state;
        private int countDown;
        public Counter(int processingTime, bool state)
        {
            this.processingTime = processingTime;
            this.state = state;
            countDown = processingTime;
        }
        public void Update()
        {
            if (state)
            {
                if (countDown > 0)
                {
                    countDown--;
                }
                else
                {
                    countDown = processingTime;
                    state = false;
                }
            }
        }
        public bool IsOccupied()
        {
            return state;
        }
        public void Assign()
        {
            state = true;
            countDown = processingTime;
        }
    }

    public class Level
    {
        private Counter[] counters;
        private int queueNum;
        private int leaving;
        public Level(int counterCount, int processingTime, bool[] states)
        {
            bool[] iniStates = new bool[counterCount];
            bool equalLength = states.Length == counterCount;
            for (int i = 0; i < counterCount; i++)
            {
                iniStates[i] = equalLength ? states[i] : false;
            }
            counters = new Counter[counterCount];
            for (int i = 0; i < counterCount; i++)
            {
                counters[i] = new Counter(processingTime, iniStates[i]);
            }
            queueNum = 0;
            leaving = 0;
        }
        public int countPeople()
        {
            int rtn = 0;
            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i].IsOccupied()) rtn++;
            }
            return rtn;
        }
        public void Update(int feedingNum)
        {
            int beforeUpdateInnerNum = countPeople();
            foreach (Counter c in counters)
            {
                c.Update();
            }
            int afterUpdateInnerNum = countPeople();
            leaving = beforeUpdateInnerNum - afterUpdateInnerNum;
            int newCapacity = counters.Length - afterUpdateInnerNum;
            queueNum += Math.Max(0, feedingNum - newCapacity);
            int entering = feedingNum + queueNum > newCapacity ? newCapacity : feedingNum + queueNum;
            queueNum = Math.Max(0, queueNum - entering);
            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i].IsOccupied()) continue;
                if (entering > 0)
                {
                    counters[i].Assign();
                    entering--;
                }
            }
        }
        public int getQueue()
        {
            return queueNum;
        }
        public int getLeaving()
        {
            return leaving;
        }
    }
    public class CounterSystem
    {
        private int comingTime;
        private int countDown;
        private int queuing;
        private int numStudent;
        private List<Level> levels;
        public CounterSystem(int levels, int students, int[] levelNumCounters, int[] levelProcessingTime, bool[][] levelStates, int peopleComingTime)
        {
            comingTime = peopleComingTime;
            countDown = comingTime;
            numStudent = students;
            queuing = 0;
            this.levels = new List<Level>();
            for (int i = 0; i < levels; i++)
            {
                Level level = new Level(levelNumCounters[i], levelProcessingTime[i], levelStates[i]);
                this.levels.Add(level);
            }
        }
        public bool Update()
        {
            if (countDown > 0)
            {
                countDown--;
            }
            else
            {
                countDown = comingTime;
                if (numStudent > 0)
                {
                    queuing++;
                    numStudent--;
                }　
            }
            int levelOutput = queuing;
            int sum = 0;
            for (int i = 0; i < levels.Count; i++)
            {
                levels[i].Update(levelOutput);
                levelOutput = levels[i].getLeaving();
                if (i == 0) queuing = levels[i].getQueue();
                sum += levels[i].countPeople();
            }
            return sum > 0 || numStudent > 0;
        }
        public int getCount()
        {
            int sum = 0;
            for (int i = 0; i < levels.Count; i++)
            {
                sum += levels[i].countPeople();
            }
            return sum;
        }
        public int getQ()
        {
            return queuing;
        }
        public String getQbyLevel()
        {
            int index = 1;
            String rtn = "";
            for (int i = 0; i < levels.Count; i++)
            {
                rtn += "Lvl" + index.ToString() +"-[";
                rtn += levels[i].getQueue().ToString();
                rtn += "]; ";
                index++;
            }
            return rtn;
        }
        public int getNumYet()
        {
            return numStudent;
        }
    }
}
