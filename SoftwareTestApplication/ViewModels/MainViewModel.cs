using SoftwareTestApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace SoftwareTestApplication.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Properties
        private string _InputValues;
        private string _OutputValues;

        private List<double> _Values;
        private bool _ValidValues = true;


        private ICommand _LargestValue;
        private ICommand _SumOddValues;
        private ICommand _SumEvenValues;

        private Brush _ResultColor;
        #endregion

        public string InputValues
        {
            get => _InputValues;
            set
            {
                _InputValues = value;
                UpdateValues();
                OnPropertyChanged("InputValues");
            }
        }
        public string OutputValues
        {
            get => _OutputValues;
            set
            {
                _OutputValues = value;
                SetBrushColor();
                OnPropertyChanged("OutputValues");
            }
        }

        public ICommand LargestValue { get => _LargestValue; private set => _LargestValue = value; }
        public ICommand SumOddValues { get => _SumOddValues; private set => _SumOddValues = value; }
        public ICommand SumEvenValues { get => _SumEvenValues; private set => _SumEvenValues = value; }

        public Brush ResultColor
        {
            get => _ResultColor;
            set
            {
                _ResultColor = value;
                OnPropertyChanged("ResultColor");
            }
        }

        /// <summary>
        /// Default Constructer
        /// </summary>
        public MainViewModel()
        {
            MainModel mainModel = new MainModel();
            InputValues = mainModel.InputValues;
            OutputValues = mainModel.OutputValues;

            LargestValue = new RelayCommand(new Action<object>(GetLargestNumber));
            SumOddValues = new RelayCommand(new Action<object>(GetSumOddValues));
            SumEvenValues = new RelayCommand(new Action<object>(GetSumEvenValues));
        }



        #region Private Methods
        private void GetLargestNumber(object obj)
        {
            OutputValues = _Values.Max().ToString();
        }
        private void GetSumOddValues(object obj)
        {
            double result = 0;
            foreach (double value in _Values)
            {
                if(value % 1 == 0 && value % 2 != 0)
                {
                    result += value;
                }
            }

            OutputValues = result.ToString();
        }
        private void GetSumEvenValues(object obj)
        {
            double result = 0;

            foreach (double value in _Values)
            {
                if (value % 2 == 0)
                {
                    result += value;
                }
            }

            OutputValues = result.ToString();
        }
        #endregion

        #region HelperMethods
        private void UpdateValues()
        {
            _Values = new List<double>();

            string[] values = InputValues.Split(',');

            foreach (var value in values)
            {
                if(double.TryParse(value, out double number))
                {
                    _Values.Add(number);
                }
                else
                {
                    _ValidValues = false;
                    break;
                }
            }
            if (!_ValidValues)
            {
                MessageBox.Show("Error with inputed values");
            }
        }

        private void SetBrushColor()
        {
            if(OutputValues == string.Empty) { return; }

            double outputValue = Convert.ToDouble(OutputValues);

            if(outputValue > 0)
            {
                ResultColor = Brushes.Green;
            }
            else if(outputValue < 0)
            {
                ResultColor= Brushes.Red;
            }
            else
            {
                ResultColor= Brushes.Black;
            }

        }
        #endregion
    }
}
