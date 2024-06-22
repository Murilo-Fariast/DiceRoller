using DiceRoller.Models;

namespace DiceRoller.Views;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
	}

    private void RollButton_Clicked(object sender, EventArgs e)
    {
		int quantidadeDeLados = Convert.ToInt32(SidesPicker.SelectedItem);
		Dice dice = new Dice(quantidadeDeLados);
		dice.Rolar();
        ResultLabel.Text = dice.NumeroSorteado.ToString();
    }
}