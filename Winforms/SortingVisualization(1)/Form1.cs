using SortingVisualization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingVisualization_1_ {
    public partial class frmMain : Form {

        public static frmMain Instance { get; set; }
        public static bool isSorted { get; set; }

        static Settings Settings { get; set; }

        Bitmap DrawArea;
        COLOR colorStatus;

        public static int upperSize;
        public static int delayMs;
        public static int arrayAccess;
        public static int comparison;
        string algorithmName;

        public frmMain() {
            InitializeComponent();

            if(Instance == null) {
                Instance = this;
            }

            upperSize = ptrbVisualArea.Size.Height;

            DrawArea = new Bitmap(ptrbVisualArea.Size.Width, ptrbVisualArea.Size.Height);
            ptrbVisualArea.Image = DrawArea;

            Settings = new Settings(Defaults.RANDOM, Defaults.SIZE, Defaults.LOWER_LIMIT, Defaults.UPPER_LIMIT,
                Defaults.DELAY, Defaults.COLORIZED, Defaults.STYLE);
            Colors.Init();
            MethodName.Init();
            VisualStyle.Init();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            // set style for lblInfo
            lblInfo.Text = "";
            lblInfo.BackColor = Color.Black;
            lblInfo.ForeColor = Color.White;

            lblStatus.Text = "";
            lblStatus.BackColor = Color.Black;
            lblStatus.ForeColor = Color.White;

            ptrbVisualArea.BackColor = Color.Black;
            listHistory.BorderStyle = BorderStyle.None;

            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.BackColor = Colors.ColorSchema[0];
            btnGenerate.ForeColor = Color.White;

            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.BackColor = Colors.ColorSchema[2];
            btnSort.ForeColor = Color.White;

            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.BackColor = Colors.ColorSchema[3];
            btnStop.ForeColor = Color.White;


            for(int i = 1; i < MethodName.MethodNames.Count + 1; i++) {
                cbxAlgortihms.Items.Add(MethodName.MethodNames[i]);
            }
        }
        bool isGenerated = false;
        private void btnGenerate_Click(object sender, EventArgs e) {
            btnSort.Text = "SORT";
            isGenerated = true;
            GetSettings();
            CreateArray();
        }

        public void GetSettings() {
            int size = Defaults.SIZE;

            int delay = (int)Defaults.DELAY;


            ApplySettings(size, delay);
        }

        public void ApplySettings(int size = Defaults.SIZE, int delay = Defaults.DELAY, bool isColor = Defaults.COLORIZED,
            int style = Defaults.STYLE, bool isRandom = Defaults.RANDOM, int lower = Defaults.LOWER_LIMIT, int upper = Defaults.UPPER_LIMIT
            ) {
            Settings = new Settings(isRandom, size, lower, upper, delay, isColor, style);
        }

        private void CreateArray() {
            ArrayHolder.Arr = new int[Defaults.SIZE];
            GenerateRandomNumbers();
        }

        private void GenerateRandomNumbers() {
            Random rand = new Random();

            for(int i = 0; i < ArrayHolder.Arr.Length; i++) {
                ArrayHolder.Arr[i] = ptrbVisualArea.Size.Height - rand.Next(50, ptrbVisualArea.Size.Height);
            }

            lblStatus.Text = STATUS.GENERATED.ToString();
            VisualizeArray();
        }

        Graphics graphic;
        Pen pen;

        private void VisualizeArray() {
            graphic = Graphics.FromImage(DrawArea);
            pen = new Pen(Brushes.White);
            pen.Width = ptrbVisualArea.Size.Width / ((float)ArrayHolder.Arr.Length * 1.245f);

            graphic.Clear(ptrbVisualArea.BackColor);

            float x1 = 5;
            float y1 = ptrbVisualArea.Size.Height;

            float increase = pen.Width;

            for(int i = 0; i < ArrayHolder.Arr.Length; i++) {
                LineVisualize(pen, x1, y1, i);
                UpdateInfo();
                x1 += increase + 1;
            }

            ptrbVisualArea.Refresh();
        }

        private void LineVisualize(Pen pen, float x, float y, int i) {
            graphic.DrawLine(pen, x, y, x, ptrbVisualArea.Size.Height - ArrayHolder.Arr[i]);
        }

        private void UpdateInfo() {
            lblInfo.Text = $"Comparisons: {comparison} | Array Access: {arrayAccess}";
        }

        public void SetStatus() {
            lblStatus.Text = (isSorted == true ? STATUS.SORTED.ToString() : STATUS.SORTING.ToString());
        }

        private void btnSort_Click(object sender, EventArgs e) {
            comparison = 0;
            arrayAccess = 0;

            isSorted = false;
            
            if(!isGenerated) {
                MessageBox.Show("Please generate array before using this function !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            SetAlgorithm();
        }

        Thread thread;

         private void SetAlgorithm() {
            int selectedIndex = cbxAlgortihms.SelectedIndex + 1;

            string selectedAlgorithm;

            try {
                selectedAlgorithm = MethodName.MethodNames[selectedIndex];
                algorithmName = MethodName.MethodNames[selectedIndex].ToString();
            } catch {
                MessageBox.Show("Please choose one algorithm !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedAlgorithm = MethodName.MethodNames[2];
                return;
            }

            switch(selectedAlgorithm) {
                case "Selection Sort":
                    thread = new Thread(() => Algorithms.SelectionSort(ArrayHolder.Arr));
                    thread.IsBackground = true;
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;

                case "Bubble Sort":
                    thread = new Thread(() => Algorithms.BubbleSort(ArrayHolder.Arr));
                    thread.IsBackground = true;
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;

                case "Insertion Sort":
                    thread = new Thread(() => Algorithms.InsertionSort(ArrayHolder.Arr));
                    thread.IsBackground = true;
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;

                case "Shell Sort":
                    thread = new Thread(() => Algorithms.ShellSort(ArrayHolder.Arr));
                    thread.IsBackground = true;
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;

                case "Merge Sort":
                    thread = new Thread(() => Algorithms.MergeSort(ArrayHolder.Arr, 0,
                        Settings.Size - 1, Settings.Size));
                    thread.IsBackground = true;
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;

                case "Quick Sort":
                    thread = new Thread(() => Algorithms.QuickSort(ArrayHolder.Arr, 0, ArrayHolder.Arr.Length - 1));
                    thread.IsBackground = true;
                    thread.Start();
                    ThreadingArrayVisualSet();
                    AddRecent();
                    break;
                default:
                    MessageBox.Show("Select invalid algorithm !");
                    break;
            }
        }

        private void ThreadingArrayVisualSet() {
            int visualDelay = Settings.Delay + 1;

            while(thread.IsAlive) {
                Application.DoEvents();
                Thread.Sleep(visualDelay);
                SetStatus();
                VisualizeArray();
            }

            VisualizeArray();
            isSorted = true;
            SetStatus();

        }

        private void AddRecent() {
            listHistory.Items.Add($"> {algorithmName} ({Settings.Size}, {Settings.Delay}ms )");
            listHistory.Items.Add($"   Sorted in {Algorithms.sortTime.Elapsed}");
            listHistory.Items.Add($"   Array access: {comparison}");
            listHistory.Items.Add($"   Comparison: {arrayAccess}");
            listHistory.Items.Add("\n");
        }

        private void btnStop_Click(object sender, EventArgs e) {
            thread.Abort();
            isSorted = false;
            btnSort.Text = "CONTINUE";
        }
    }
}
