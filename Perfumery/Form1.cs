namespace Perfumery
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Perfumery> perfumeries;
        public Form1()
        {
            InitializeComponent();
            perfumeries = new Dictionary<string, Perfumery>();
        }

        private void btnAddPerfumery_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (!string.IsNullOrWhiteSpace(name) && !perfumeries.ContainsKey(name))
            {
                perfumeries[name] = new Perfumery(name);
                listBoxPerfumeries.Items.Add(name);
                MessageBox.Show($"Perfumery {name} added.");
            }
            else
            {
                MessageBox.Show("Invalid or duplicate perfumery name.");
            }
        }

        private void btnAddPerfume_Click(object sender, EventArgs e)
        {
            string selectedPerfumery = listBoxPerfumeries.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedPerfumery) && perfumeries.ContainsKey(selectedPerfumery))
            {
                string brand = txtBrand.Text;
                if (double.TryParse(txtPrice.Text, out double price) && price > 0)
                {
                    Perfume newPerfume = new Perfume(brand, price);
                    perfumeries[selectedPerfumery].AddPerfume(newPerfume);
                    MessageBox.Show($"Perfume {brand} added to {selectedPerfumery}.");
                    UpdatePerfumeList(selectedPerfumery);
                }
                else
                {
                    MessageBox.Show("Invalid price.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid perfumery.");
            }
        }
        private void btnSellPerfume_Click(object sender, EventArgs e)
        {
            string selectedPerfumery = listBoxPerfumeries.SelectedItem?.ToString();
            string selectedPerfume = listBoxPerfumes.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(selectedPerfumery) && !string.IsNullOrWhiteSpace(selectedPerfume) && perfumeries.ContainsKey(selectedPerfumery))
            {
                string[] perfumeDetails = selectedPerfume.Split(' ');
                int costsIndex = Array.IndexOf(perfumeDetails, "costs");
                if (costsIndex > 1 && costsIndex < perfumeDetails.Length - 1)
                {
                    try
                    {
                        string brand = string.Join(" ", perfumeDetails.Skip(1).Take(costsIndex - 1));
                        double price = double.Parse(perfumeDetails[costsIndex + 1]);
                        Perfume perfumeToSell = new Perfume(brand, price);
                        if (perfumeries[selectedPerfumery].SellPerfume(perfumeToSell))
                        {
                            MessageBox.Show($"Perfume {brand} sold from {selectedPerfumery}.");
                            UpdatePerfumeList(selectedPerfumery);
                        }
                        else
                        {
                            MessageBox.Show("Perfume not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error occurred while processing perfume: {ex.Message}");
                    }
                }
                else
                {

                    MessageBox.Show("Invalid perfume format. Please select a valid perfume.");
                }
            }
            else
            {
                MessageBox.Show("Please select a perfumery and a perfume.");
            }
        }

        private void UpdatePerfumeList(string perfumeryName)
        {
            listBoxPerfumes.Items.Clear();
            var perfumes = perfumeries[perfumeryName].GetPerfumes();
            foreach (var perfume in perfumes)
            {
                listBoxPerfumes.Items.Add(perfume.ToString());
            }
        }

        private void btnPerfumeryInfo_Click_1(object sender, EventArgs e)
        {
            string selectedPerfumery = listBoxPerfumeries.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedPerfumery) && perfumeries.ContainsKey(selectedPerfumery))
            {
                labelRezult.Text = perfumeries[selectedPerfumery].ToString();
            }
            else
            {
                labelRezult.Text = "Please select a valid perfumery.";
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            labelRezult.Text = "";
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            string selectedPerfumery = listBoxPerfumeries.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedPerfumery) && perfumeries.ContainsKey(selectedPerfumery))
            {
                double totalPrice = perfumeries[selectedPerfumery].CalculateTotalPrice();
                labelRezult.Text = $"{selectedPerfumery}: {totalPrice:C}";
            }
            else
            {
                labelRezult.Text = "Please select a valid perfumery.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string selectedPerfumery = listBoxPerfumeries.Text;
            string selectedPerfume = listBoxPerfumes.Text;

            if (string.IsNullOrWhiteSpace(selectedPerfumery) || string.IsNullOrWhiteSpace(selectedPerfume) || !perfumeries.ContainsKey(selectedPerfumery))
            {
                MessageBox.Show("Please select a perfumery and a perfume.");
                return;
            }

            string[] perfumeDetails = selectedPerfume.Split(' '); //parfyum 57,12

            try
            {
                string brand = string.Join(" ", perfumeDetails.Take(perfumeDetails.Length - 1));
                double price = double.Parse(perfumeDetails.Last());
                Perfume perfumeToSell = new Perfume(brand, price);
                if (!perfumeries[selectedPerfumery].SellPerfume(perfumeToSell))
                {
                    MessageBox.Show("Perfume not found.");
                    return;
                }
                MessageBox.Show($"Perfume {brand} sold from {selectedPerfumery}.");
                UpdatePerfumeList(selectedPerfumery);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while processing perfume: {ex.Message}");
            }
        }
    }
}
