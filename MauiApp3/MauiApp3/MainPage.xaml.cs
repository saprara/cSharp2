namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;



        public MainPage()
        {
            InitializeComponent();


            // Subscribe to event handlers
            billInput.TextChanged += OnBillInputTextChanged;
            tipPercentSlider.ValueChanged += OnTipPercentSliderValueChanged;
            roundDown.Clicked += OnRoundDownClicked;
            roundUp.Clicked += OnRoundUpClicked;
        }


        private void OnBillInputTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTipAndTotal();
        }

        private void OnTipPercentSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateTipAndTotal();
            tipPercent.Text = $"{(int)e.NewValue}%"; // Update tip percentage label
        }

        private void OnNormalTip(object sender, EventArgs e)
        {
            tipPercentSlider.Value = 15; // Set tip percentage to 15%
            UpdateTipAndTotal();
        }

        private void OnGenerousTip(object sender, EventArgs e)
        {
            tipPercentSlider.Value = 20; // Set tip percentage to 20%
            UpdateTipAndTotal();
        }

        private void OnRoundDownClicked(object sender, EventArgs e)
        {
            double total = CalculateTotal();
            totalOutput.Text = $"{Math.Floor(total):0.00}"; // Round down total and update label
        }

        private void OnRoundUpClicked(object sender, EventArgs e)
        {
            double total = CalculateTotal();
            totalOutput.Text = $"{Math.Ceiling(total):0.00}"; // Round up total and update label
        }

        private void UpdateTipAndTotal()
        {
            double bill;
            if (double.TryParse(billInput.Text, out bill))
            {
                double tipPercent = tipPercentSlider.Value / 100;
                double tip = bill * tipPercent;
                double total = bill + tip;

                tipOutput.Text = $"{tip:0.00}";
                totalOutput.Text = $"{total:0.00}";
            }
        }

        private double CalculateTotal()
        {
            double bill;
            if (double.TryParse(billInput.Text, out bill))
            {
                double tipPercent = tipPercentSlider.Value / 100;
                double tip = bill * tipPercent;
                return bill + tip;
            }
            return 0;
        }
    }
}

