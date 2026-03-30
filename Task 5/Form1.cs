namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int[] BubbleSortProcedural(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public class DescendingSorter
        {
            public void Sort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        
                        if (array[j] < array[j + 1])
                        {
                            Swap(array, j, j + 1);
                        }
                    }
                }
            }

            private void Swap(int[] array, int a, int b)
            {
                int temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }
        }

        private void btnSortBubble_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };

            
            int[] sorted = BubbleSortProcedural(numbers);

            listBoxResults.DataSource = null; 
            listBoxResults.DataSource = sorted;
        }

        private void btnCDO_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };

           
            DescendingSorter sorter = new DescendingSorter();
            sorter.Sort(numbers);

            listBoxResults.DataSource = null;
            listBoxResults.DataSource = numbers;
        }
    }
}
