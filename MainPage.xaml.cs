namespace TDMPW_2P_EX;

public partial class MainPage : TabbedPage
{
	int palo = 1;
	int refre = 0;
	int nacho = 0;
	int pancho = 0;
	double cantidad = 1;
	double totalPalo = 0;
	double totalRefre = 0;
	double totalNa = 0;
	double totalPan = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void cambiarCombo(object sender, EventArgs e)
	{
		txtAlimentos.Text = "Combos";

		imgCombo1.Source = ImageSource.FromFile("combo1.png");
		lblCombo1.Text = "Cuates";
		preCombo1.Text = "$223.00"; 

		imgCombo2.Source = ImageSource.FromFile("combo2.png");
		lblCombo2.Text = "Nachos en Pareja";
		preCombo2.Text = "$200.00"; 

		imgCombo3.Source = ImageSource.FromFile("combo3.png");
		lblCombo3.Text = "Individual";
		preCombo3.Text = "$132.00";

		imgCombo4.Source = ImageSource.FromFile("combo4.png");
		lblCombo4.Text = "Barbie";
		preCombo4.Text = "$210.00";

		imgCombo5.Source = ImageSource.FromFile("combo5.png");
		lblCombo5.Text = "Princesa Peach";
		preCombo5.Text = "$ 90.00";

		imgCombo6.Source = ImageSource.FromFile("combo6.png");
		lblCombo6.Text = "Kung Fu Panda 4";
		preCombo6.Text = "$175.00";
	}

	private void cambiarMaxi(object sender, EventArgs e)
	{
		txtAlimentos.Text = "Maxicombos";
		imgCombo1.Source = ImageSource.FromFile("maxicombo1.png");
		lblCombo1.Text = "Pareja Dulce";
		preCombo1.Text = "$223.00"; 

		imgCombo2.Source = ImageSource.FromFile("maxicombo2.png");
		lblCombo2.Text = "Nacho Amigos";
		preCombo2.Text = "$402.00"; 

		imgCombo3.Source = ImageSource.FromFile("maxicombo3.png");
		lblCombo3.Text = "Mega Mix";
		preCombo3.Text = "$348.00";

		imgCombo4.Source = ImageSource.FromFile("maxicombo4.png");
		lblCombo4.Text = "Barbie Girl";
		preCombo4.Text = "$280.00";

		imgCombo5.Source = ImageSource.FromFile("maxicombo5.png");
		lblCombo5.Text = "Super Mario";
		preCombo5.Text = "$305.00";
		
		imgCombo6.Source = ImageSource.FromFile("maxicombo6.png");
		lblCombo6.Text = "Ghostbusters";
		preCombo6.Text = "$319.00";
	}
	
	private void OnCantidad(object sender, EventArgs e)
	{
		cantidad = stpCantidad.Value;
		numCantidad.Text = stpCantidad.Value.ToString("N0");

		if(palo == 1){
			totalPalo = 90 * cantidad;
			precioPrincipal.Text = "$" + totalPalo.ToString("N0") + ".00";
		}else if(refre == 1){
			totalRefre = 90 + (25 * cantidad);
			precioPrincipal.Text = "$" + totalRefre.ToString("N0") + ".00";
		}else if(nacho == 1){
			totalNa = 90 + (45 * cantidad);
			precioPrincipal.Text = "$" + totalNa.ToString("N0") + ".00";
		}else if(pancho == 1){
			totalPan = 90 + (35 * cantidad);
			precioPrincipal.Text = "$" + totalPan.ToString("N0") + ".00";
		}
	}

	private void agregarPalomitas(object sender, EventArgs e)
	{
		imgPrincipal.Source = ImageSource.FromFile("palomitas.png");
		tituloPrincipal.Text = "Combo Tradicional" ;
		desPrincipal.Text = "Tu combo personalizado incluye Palomitas Jumbo para llevar (285 gr) [$90.00 c/u].";

		totalPalo = 90 * cantidad;

		numCantidad.Text = stpCantidad.Value.ToString("N0");
		precioPrincipal.Text = "$" + totalPalo.ToString("N0") + ".00";	

		palo = 1;
		refre = 0;
		nacho = 0;
		pancho = 0;	
	}

	private void agregarRefrescos(object sender, EventArgs e)
	{
		imgPrincipal.Source = ImageSource.FromFile("palomitasrefre.png");
		tituloPrincipal.Text = "Combo Refrescos" ;
		desPrincipal.Text = "Tu combo personalizado incluye Palomitas Jumbo para llevar (285 gr) [$90.00 c/u] + Refresco Mediano (750 ml) [$25.00 c/u].";

		totalRefre = 90 + (25 * cantidad);

		numCantidad.Text = stpCantidad.Value.ToString("N0");
		precioPrincipal.Text = "$" + totalRefre.ToString("N0") + ".00";	

		palo = 0;
		refre = 1;
		nacho = 0;
		pancho = 0;	
	}
	private void agregarNachos(object sender, EventArgs e)
	{
		imgPrincipal.Source = ImageSource.FromFile("palomitasna.png");
		tituloPrincipal.Text = "Combo Nachos" ;
		desPrincipal.Text = "Tu combo personalizado incluye Palomitas Jumbo para llevar (285 gr) [$90.00 c/u] + Nachos Grandes Extra Queso (230 gr) [$45.00 c/u].";

		totalNa = 90 + (45 * cantidad);

		numCantidad.Text = stpCantidad.Value.ToString("N0");
		precioPrincipal.Text = "$" + totalNa.ToString("N0") + ".00";

		palo = 0;
		refre = 0;
		nacho = 1;
		pancho = 0;		
	}
	private void agregarPanchos(object sender, EventArgs e)
	{
		imgPrincipal.Source = ImageSource.FromFile("palomitasho.png");
		tituloPrincipal.Text = "Combo HotDogs" ;
		desPrincipal.Text = "Tu combo personalizado incluye Palomitas Jumbo para llevar (285 gr) [$90.00 c/u] + HotDogs Medianos (340 gr) [$35.00 c/u].";

		totalPan = 90 + (35 * cantidad);

		numCantidad.Text = stpCantidad.Value.ToString("N0");
		precioPrincipal.Text = "$" + totalPan.ToString("N0") + ".00";	

		palo = 0;
		refre = 0;
		nacho = 0;
		pancho = 1;	
	}
}