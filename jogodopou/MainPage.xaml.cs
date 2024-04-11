namespace jogodopou;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	

		timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += (s, e) => PassouTempo();
	{
	}
Iniciar();
	

	void ClicouBotaoTrocaPersongame()
	{

	}

IDispatcherTimer timer;
	mustang Mustang;
	omega Omega;
	opala Opala;
	fusca Fusca; 
	garagem Atual;


		void Iniciar()
		{
			Mustang= new mustang();
		    Opala = new opala();
			Fusca = new fusca();
			Omega = new omega();
			Atual = new garagem();
			
			
			
			Atual = mustang;
			ImagemAnimal.Source = Atual.GetArquivo();
			LabelNome.Text = Atual.GetNomePersonagem();

			Mustang.Setgasolina(0.5);
			Mustang.Setoleo(0.5);
			Mustang.Setturbo(0.5);

			Opala.Setgasolina(0.5);
			Opala.Setoleo(0.5);
			Opala.Setturbo(0.5);

			Omega.Setgasolina(0.5);
			Omega.Setoleo(0.5);
			Omega.Setturbo(0.5);
			
			Fusca.Setgasolina(0.5);
			Fusca.Setoleo(0.5);
			Fusca.Setturbo(0.5);
			

			timer.Start();
		}
		
		}
}