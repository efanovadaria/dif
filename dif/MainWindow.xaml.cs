using System;
using System.Windows;
using System.Windows.Controls;

namespace dif
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbTips.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!double.TryParse(txtBill.Text, out double bill))
                {
                    MessageBox.Show("Введите корректную сумму счета.");
                    return;
                }

                if (!int.TryParse(txtGuests.Text, out int guests))
                {
                    MessageBox.Show("Введите корректное количество гостей.");
                    return;
                }

                ComboBoxItem selectedItem =
                    (ComboBoxItem)cmbTips.SelectedItem;

                int tipPercent =
                    int.Parse(selectedItem.Content.ToString());

                double result =
                    difLogic.CalculateTotal(
                        bill,
                        guests,
                        tipPercent);

                txtResult.Text =
                    $"Сумма на одного человека: {result:F2}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }
    }
}