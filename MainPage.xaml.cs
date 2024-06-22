namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }

      

        private void RollButton_Clicked(object sender, EventArgs e)
        {
            //Pego o valor que o usuário selecionou no Picker
            //Eu sorteio de 1 até X
            //Sorteio um número aleatório ENTRE 1 e X, onde X é o número de lados
            //Exibo o resultado da rolagem do dado na Label

            int selectedSides = Convert.ToInt32(SidesPicker.SelectedItem);
            int numeroSorteado = new Random().Next(1, selectedSides + 1);
            ResultLabel.Text = numeroSorteado.ToString();

        }
    }

}
