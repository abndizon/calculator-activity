using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorActivity
{
    public partial class Form1 : Form
    {
        char operation = ' ';
        double lastNumber = 0;
        double screenNumber;
        double memory=0;
        bool overwrite = false;
        bool historyOverwrite = false;
        double numberCopy;
        double valueToOperate;
        double memoryScreenNumber;
        bool isNumeric;
        bool performOp;
        bool operationLastClicked;
        bool equalLastClicked;
        string history="";
        string operationString = "";
        string lastOperationString = "";
        string viewHistory;
        int i, x;
        int index;

        List<double> memoryList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        //For clicking button numbers
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            // Get the sender as a Button.
            Button btn = sender as Button;

            PrintNumbersToTextbox(btn.Text);
        }

        //Decimal button click
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            //Check if overwrite is true then add zero automatically
            if (overwrite)
            {
                screenTextBox.Text = "0";
                overwrite = false;
            }

            //Check if there is already a decimal in the number
            if (!(screenTextBox.Text.Contains(".")))
            {
                screenTextBox.Text += decimalButton.Text;
            }

            operationLastClicked = false;
        }

        //Plus-Minus Button click
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            //Check if it is zero or not
            if (Convert.ToDouble(screenTextBox.Text)!=0)
            {
                if (!(screenTextBox.Text.Contains("-")))
                {
                    string temp = screenTextBox.Text;
                    screenTextBox.Text = "-" + temp;
                }
                else
                {
                    index = screenTextBox.Text.IndexOf('-');
                    screenTextBox.Text = screenTextBox.Text.Remove(index, 1);
                }
            }
        }

        //When operation is selected
        private void OperationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if combobox is empty or not
            if (operationComboBox.SelectedIndex > -1)
            {
                //Error handling
                try
                {
                    if (operation == '÷' && screenTextBox.Text == "0")
                    {
                        MessageBox.Show("Cannot divide by zero", "Divide Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearScreen();
                    }
                    else
                    {
                        lastOperationString = operationString;
                        //For history
                        switch (Convert.ToChar(operationComboBox.Text))
                        {
                            case '+':
                                operationString = "Add";
                                break;
                            case '-':
                                operationString = "Subtract";
                                break;
                            case 'x':
                                operationString = "Multiply";
                                break;
                            case '÷':
                                operationString = "Divide";
                                break;
                        }

                        //Check if there is a decimal point in the last index, remove if there is
                        if (screenTextBox.Text[screenTextBox.Text.Length - 1] == '.')
                        {
                            screenTextBox.Text = screenTextBox.Text.Remove(screenTextBox.Text.Length - 1, 1);
                        }

                        //If operations are needed to perform
                        if (!overwrite || performOp)
                        {
                            history += screenTextBox.Text + "  " + operationString + "  ";
                            viewHistory += screenTextBox.Text + " " + operationComboBox.Text + " ";
                            screenNumber = Convert.ToDouble(screenTextBox.Text);

                            if (lastNumber == 0)
                                lastNumber = Convert.ToDouble(screenTextBox.Text);
                            else
                            {
                                switch (operation)
                                {
                                    case '+':
                                        lastNumber += screenNumber;
                                        break;
                                    case '-':
                                        lastNumber -= screenNumber;
                                        break;
                                    case 'x':
                                        lastNumber *= screenNumber;
                                        break;
                                    case '÷':
                                        lastNumber /= screenNumber;
                                        break;
                                }

                            }

                            //Check if user enters more than 2 numbers for operations
                            if (operation != ' ')
                            {
                                screenTextBox.Text = lastNumber.ToString();
                            }

                            overwrite = true;
                        }

                        //if operation is changed
                        else
                        {
                            history = history.Remove((history.Length - (2 + lastOperationString.Length)), (2 + lastOperationString.Length));
                            history += operationString + "  ";
                            viewHistory = viewHistory.Remove(viewHistory.Length - 2, 2);
                            viewHistory += operationComboBox.Text + " ";
                        }

                        viewRichTextBox.Text = viewHistory;

                        //Assign operation to variable
                        operation = Convert.ToChar(operationComboBox.Text);
                        operationLastClicked = true;

                        performOp = false;
                        equalLastClicked = false;
                        historyOverwrite = false;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception Catch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearScreen();
                }
            }
        }

        //Equal button click
        private void EqualButton_Click(object sender, EventArgs e)
        {
            EqualButtonFunction();
        }

        //Clear button click
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        //Delete button click
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteNumber();
        }
        
        //Keypress detector
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Char.IsDigit(Convert.ToChar(e.KeyCode)))
            {
                PrintNumbersToTextbox(Convert.ToChar(e.KeyCode).ToString());
            }
            else if (e.KeyCode == Keys.Back)
            {
                DeleteNumber();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                EqualButtonFunction();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(screenTextBox.Text);
            }
                
            if (e.Control && e.KeyCode == Keys.V)
            {
                ValidateClipboardText();
            }
                
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(screenTextBox.Text);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidateClipboardText();
        }

        private void ImportFromTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //MessageBox.Show(openFileDialog.FileName);
                    bool errorFound = false;
                    int lineCount = 1;
                    int lastIndex = 0;
                    int tryOutput = 0;
                    int indexInside = 0;
                    double tryConvert=0.0;
                    string testParse = "";
                    string errorMessage = "";
                    string addToHistory="";
                    List<string> historyList = new List<string>();

                    //Check if text file is empty or not
                    if (new FileInfo(openFileDialog.FileName).Length == 0)
                    {
                        MessageBox.Show("File is empty", "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Check text file line by line
                        foreach (string line in File.ReadLines(openFileDialog.FileName))
                        {
                            if (lineCount == 1)
                            {
                                if (line != "Hist_ID\t\tHist_Action\t\tHist_Value")
                                {
                                    errorFound = true;
                                    errorMessage = "There is something wrong in the file header. (Line#:" + lineCount + ")";
                                }
                            }
                            else
                            {
                                if (!errorFound)
                                {
                                    //Find index
                                    for (i = 0; i < line.Length; i++)
                                    {
                                        if (line[i] == Convert.ToChar(9))
                                        {
                                            index = i;
                                            break;
                                        }
                                    }

                                    //Check history id
                                    for (i = 0; i < index; i++)
                                    {
                                        if (!int.TryParse(line[i].ToString(), out tryOutput))
                                        {
                                            errorFound = true;
                                            errorMessage = "There is something wrong in the history id. (Line#:" + lineCount + ")";
                                            break;
                                        }
                                    }

                                    lastIndex = index + 2;

                                    //Check history action

                                    for (i = lastIndex; i < line.Length; i++)
                                    {
                                        if (line[i] == Convert.ToChar(9))
                                        {
                                            index = i;
                                            break;
                                        }
                                    }

                                    addToHistory = "";
                                    while (lastIndex < index)
                                    {
                                        for (i = lastIndex; i < index; i++)
                                        {
                                            if (line[i] == ' ')
                                            {
                                                indexInside = i;
                                                break;
                                            }
                                        }

                                        testParse = "";

                                        for (i = lastIndex; i < indexInside; i++)
                                        {
                                            testParse += line[i].ToString();
                                        }
                                        addToHistory += testParse + "  ";

                                        if (!double.TryParse(testParse, out tryConvert))
                                        {
                                            if (testParse != "Equals" && testParse != "Add" && testParse != "Subtract" && testParse != "Multiply" && testParse != "Divide")
                                            {
                                                errorFound = true;
                                                errorMessage = "There is something wrong in the history action. (Line#:" + lineCount + ")";
                                                break;
                                            }
                                        }

                                        lastIndex = indexInside + 2;
                                    }

                                    lastIndex = index + 2;

                                    //Check history value
                                    testParse = "";

                                    for (i = lastIndex; i < line.Length; i++)
                                    {
                                        testParse += line[i].ToString();
                                    }

                                    if (!double.TryParse(testParse, out tryConvert))
                                    {
                                        errorFound = true;
                                        errorMessage = "There is something wrong in the history value. (Line#:" + lineCount + ")";
                                        break;
                                    }
                                    else
                                    {
                                        addToHistory += testParse;
                                        historyList.Add(addToHistory);
                                    }
                                }
                            }

                            lineCount++;

                        }

                        if (errorFound)
                        {
                            MessageBox.Show("Not a valid history file\n" + errorMessage);
                        }
                        else
                        {
                            historyListBox.Items.Clear();
                            foreach (string str in historyList)
                            {
                                historyListBox.Items.Add(str);
                            }
                            clearHistoryButton.Visible = true;
                            historyLabel.Visible = false;
                            historyLabel.Visible = false;
                        }
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ClearScreen();
                }
            }
        }

        private void ExportToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyListBox.Items.Count>0)
            {
                saveFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("History is empty", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Memory Add and Memory Minus Click
        private void memoryOperation_Click(object sender, EventArgs e)
        {
            // Get the sender as a Button.
            Button btn = sender as Button;

            try
            {
                memoryScreenNumber = Convert.ToDouble(screenTextBox.Text);

                if (btn.Text == "M+")
                {
                    memory += memoryScreenNumber;
                }
                else if (btn.Text == "M-")
                {
                    memory -= memoryScreenNumber;
                }

                memoryList.Insert(0, memory);

                memoryListBox.Items.Clear();
                foreach (double items in memoryList)
                {
                    memoryListBox.Items.Add(items.ToString());
                }

                overwrite = true;
                performOp = true;
                mRecallButton.Enabled = true;
                mClearButton.Enabled = true;
                memoryLabel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearScreen();
            }
        }

        private void mRecallButton_Click(object sender, EventArgs e)
        {
            screenTextBox.Text = memory.ToString();
        }
        private void mClearButton_Click(object sender, EventArgs e)
        {
            memory = 0;
            memoryListBox.Items.Clear();
            memoryList.Clear();
            mRecallButton.Enabled = false;
            mClearButton.Enabled = false;
            memoryLabel.Visible = true;
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog.FileName=="")
            {
                MessageBox.Show("Filename is empty");
            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);
                    sw.WriteLine("Hist_ID\t\tHist_Action\t\tHist_Value");

                    int id = 1;

                    //Get index of history value
                    foreach (string items in historyListBox.Items)
                    {
                        sw.Write(id + "\t\t");

                        index = 0;
                        for (i = items.Length - 1; i >= 0; i--)
                        {
                            if (items[i] == ' ')
                            {
                                index = i;
                                break;
                            }
                        }

                        //Write History Action
                        for (x = 0; x <= index; x++)
                        {
                            sw.Write(items[x]);
                        }

                        sw.Write("\t\t");

                        //Write History Value
                        for (x = index + 1; x < items.Length; x++)
                        {
                            sw.Write(items[x]);
                        }

                        sw.Write(Environment.NewLine);

                        id++;
                    }

                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
            clearHistoryButton.Visible = false;
            historyLabel.Visible = true;
        }

        private void viewRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            viewRichTextBox.SelectionLength = 0;
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historyListBox.SelectedIndex>-1)
            {
                string tmp = historyListBox.SelectedItem.ToString();
                string num = "";
                string lastNumStr = "";

                tmp = historyListBox.SelectedItem.ToString().Replace("Add", "+");
                tmp = tmp.Replace("Subtract", "-");
                tmp = tmp.Replace("Multiply", "x");
                tmp = tmp.Replace("Divide", "÷");
                tmp = tmp.Replace("Equals", "=");

                //Remove extra spaces
                for (i=tmp.Length-1; i>=0; i--)
                {
                    if (tmp[i]==' ')
                    {
                        tmp=tmp.Remove(i,1);
                        i--;
                    }
                }

                //Get index to remove the value
                for (i = tmp.Length - 1; i >= 0; i--)
                {
                    if (tmp[i] == ' ')
                    {
                        index = i;
                        break;
                    }
                }
                
                //Get the value
                for (i=0; i<tmp.Length; i++)
                {
                    if (i > index)
                    {
                        num += tmp[i];
                    }
                }

                tmp = tmp.Remove((index + 1), ((tmp.Length - 1) - index));

                //Get last value

                for (i = 0; i < tmp.Length; i++)
                {
                    if (tmp[i] == ' ')
                    {
                        index = i;
                        break;
                    }
                }

                for (i = 0; i < index; i++)
                {
                    lastNumStr += tmp[i];
                }

                //Get operation index
                for (i = tmp.Length - 1; i >= 0; i--)
                {
                    if (tmp[i] == '+' || tmp[i] == '-' || tmp[i] == 'x' || tmp[i] == '÷')
                    {
                        index = i;
                        break;
                    }
                }

                

                //screenTextBox.Text = num;
                //viewRichTextBox.Text = tmp;
                //operationComboBox.SelectedIndex = -1;
                //lastNumber = Convert.ToDouble(num);
                //operation = tmp[tmp.Length-2];
                //overwrite = true;
                //historyOverwrite = false;
                //numberCopy = 0;
                //valueToOperate = 0;
                //memoryScreenNumber = 0;
                //performOp = false;
                //operationLastClicked = false;
                //equalLastClicked = false;
                //history = "";
                //operationString = "";
                //viewHistory = "";
                //lastOperationString = "";


                Console.WriteLine(operation);
            }
        }

        //----------My functions for the GUI---------------

        //Printing of numbers in textbox
        private void PrintNumbersToTextbox(string input)
        {
            //Count digits in textbox
            int numCount = 0;
            for (int i=0; i < screenTextBox.Text.Length; i++)
            {
                if (Char.IsDigit(screenTextBox.Text[i]))
                    numCount++;
            }

            if (numCount < 16 || overwrite)
            {
                //Check if it contains zero as default or if operation is already selected
                if (screenTextBox.Text == "0" || overwrite)
                {
                    screenTextBox.Text = input;
                    operationComboBox.SelectedIndex = -1;
                    overwrite = false;
                }
                else
                {
                    screenTextBox.Text += input;
                }
            }

            operationLastClicked = false;

            if (historyOverwrite)
            {
                viewRichTextBox.Text = "";
                historyOverwrite = false;
            }
        }
        private void DeleteNumber()
        {
            if (!operationLastClicked && !equalLastClicked)
            {
                if (screenTextBox.Text.Length > 1)
                    screenTextBox.Text = screenTextBox.Text.Remove(screenTextBox.Text.Length - 1);
                else
                {
                    screenTextBox.Text = "0";
                }
            }  
        }

        private void ClearScreen()
        {
            //Reset All
            screenTextBox.Text = "0";
            viewRichTextBox.Text = "";
            operationComboBox.SelectedIndex = -1;
            lastNumber = 0;
            operation = ' ';
            screenNumber = 0;
            overwrite = false;
            historyOverwrite = false;
            numberCopy = 0;
            valueToOperate = 0;
            memoryScreenNumber = 0;
            performOp = false;
            operationLastClicked = false;
            equalLastClicked = false;
            history = "";
            operationString = "";
            viewHistory = "";
            lastOperationString = "";
        }

        private void ValidateClipboardText ()
        {
            isNumeric = double.TryParse(Clipboard.GetText(), out numberCopy);

            if (isNumeric)
                screenTextBox.Text = numberCopy.ToString();
            else
                MessageBox.Show("Invalid Input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EqualButtonFunction()
        {
            try
            {
                if (operation == '÷' && screenTextBox.Text == "0")
                {
                    MessageBox.Show("Cannot divide by zero", "Divide Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearScreen();
                }
                else
                {
                    valueToOperate = screenNumber;
                    screenNumber = Convert.ToDouble(screenTextBox.Text);

                    //Check if there is a decimal point in the last index
                    if (screenTextBox.Text[screenTextBox.Text.Length - 1] == '.')
                    {
                        screenTextBox.Text = screenTextBox.Text.Remove(screenTextBox.Text.Length - 1, 1);
                    }

                    if (equalLastClicked)
                    {
                        lastNumber = screenNumber;
                        screenNumber = valueToOperate;
                    }

                    //Check if there is operation selected
                    if (operation != ' ')
                    {
                        //Generate last number based on operation click
                        switch (operation)
                        {
                            case '+':
                                lastNumber += screenNumber;
                                break;
                            case '-':
                                lastNumber -= screenNumber;
                                break;
                            case 'x':
                                lastNumber *= screenNumber;
                                break;
                            case '÷':
                                lastNumber /= screenNumber;
                                break;
                        }

                        if (!equalLastClicked)
                        {
                            history += screenTextBox.Text + "  Equals  " + lastNumber;
                            viewHistory += screenTextBox.Text + " = ";
                        }

                        else
                        {
                            history = screenTextBox.Text + "  " + operationString + "  " + valueToOperate + "  Equals  " + lastNumber;
                            viewHistory = screenTextBox.Text + " " + operation + " " + valueToOperate + " = ";
                        }

                        screenTextBox.Text = lastNumber.ToString();

                        //if (!overwrite)
                        //{
                        //Reset the operation
                        //operation = ' ';
                        //operationComboBox.SelectedIndex = -1;
                        //}
                    }

                    else
                    {
                        history += screenTextBox.Text + "  Equals  " + screenTextBox.Text;
                    }

                    performOp = true;
                    historyListBox.Items.Insert(0, history);
                    clearHistoryButton.Visible = true;
                    historyLabel.Visible = false;
                    viewRichTextBox.Text = viewHistory;
                    historyOverwrite = true;

                    //Reset last number and history
                    lastNumber = 0;
                    history = "";
                    viewHistory = "";
                    overwrite = true;

                    equalLastClicked = true;
                    operationLastClicked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Catch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearScreen();
            }
        }
    }
}