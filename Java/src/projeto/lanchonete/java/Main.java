package projeto.lanchonete.java;

//imports
import java.util.Scanner;
import java.io.IOException;


//variaveis gloabais


class Main {
	
	public static void main(String Args[]) throws IOException, InterruptedException {
		
		boolean endPedido=true;
		Scanner teclado = new Scanner(System.in);
		System.out.println("Ol� Bem-Vindo ao Nossa Lanchonete Como podemos lhe chamar para nosso atendimento: ");
		String nameCliente=teclado.nextLine();
		do {
			System.out.println(nameCliente+ " o que gostaria de pedir\n[1]Lanche -- [2]Pizza -- [3]Salgados");
			int numTipo= teclado.nextInt();
			String p="";
			switch(numTipo) {
				case 1:
					p="Lanche";
					System.out.println("[1]P�o de Hamburguer -- [2]P�o Franc�s");
						int pao = teclado.nextInt();
						p+=(pao>1)? "\n\nP�o Franc�s" : "\n\nP�o de Hamburguer";
						System.out.println("Deseja Colocar Ketchup [1]Sim -- [2]Nao");
						int ketchup=teclado.nextInt();
						if(ketchup == 1) p += "\nKetchup";
						System.out.println("Deseja Colocar Mostarda [1]Sim -- [2]N�o");
						int mostarda=teclado.nextInt();
						if(mostarda == 1) p += "\nMostarda";
						System.out.println("Deseja Colocar Pasta De Alho [1]Sim -- [2]N�o");
						int pasta=teclado.nextInt();
						if(pasta == 1) p += "\nPasta de Alho";
						System.out.println("Deseja Colocar Maionese [1]Sim -- [2]N�o");
						int maionese=teclado.nextInt();
						if(maionese == 1) p += "\nMaionese";
						System.out.println("Deseja Colocar Batata Palha [1]Sim -- [2]N�o");
						int batata=teclado.nextInt();
						if(batata == 1) p += "\nBatat Palha";
						System.out.println("Deseja Colocar Pimenta [1]Sim -- [2]N�o");
						int pimenta=teclado.nextInt();
						if(pimenta == 1) p += "\nPimenta";
						System.out.println("Deseja Colocar Hamburguer [1]Sim -- [2]N�o");
						int hamburguer=teclado.nextInt();
						if(hamburguer==1) {
							System.out.println("Quantas Camadas De Hamburguer Deseja Colocar ");
							int qntdHamburguer = teclado.nextInt();
							if(hamburguer == 1) p += "\nCamadas de Hamburguer: " + qntdHamburguer;
						}
						System.out.println("Deseja Colocar Tomate [1]Sim -- [2]N�o");
						int tomate=teclado.nextInt();
						if(tomate==1) {
							System.out.println("Quantas Camadas De Tomate Deseja Colocar ");
							int qntdTomate = teclado.nextInt();
							if(tomate == 1) p += "\nCamadas de Tomate: " + qntdTomate;
						}
						System.out.println("Deseja Colocar Alface [1]Sim -- [2]N�o");
						int alface=teclado.nextInt();
						if(alface==1) {
							System.out.println("Quantas Camadas De Alface Deseja Colocar ");
							int qntdAlface = teclado.nextInt();
							if(alface == 1) p += "\nCamadas de Alface: " + qntdAlface;
						}
						System.out.println("Deseja Colocar Cebola [1]Sim -- [2]N�o");
						int cebola=teclado.nextInt();
						if(cebola==1) {
							System.out.println("Quantas Camadas De Cebola Deseja Colocar ");
							int qntdCebola = teclado.nextInt();
							if(cebola == 1) p += "\nCamadas de Cebola: " + qntdCebola;
						}
						System.out.println("Deseja Colocar Bacon [1]Sim -- [2]N�o");
						int bacon=teclado.nextInt();
						if(bacon==1) {
							System.out.println("Quantas Camadas De Bacon Deseja Colocar ");
							int qntdBacon = teclado.nextInt();
							if(bacon == 1) p += "\nCamadas de Bacon: " + qntdBacon;
						}
						System.out.println("Deseja Colocar Queijo [1]Sim -- [2]N�o");
						int queijo=teclado.nextInt();
						if(queijo==1) {
							System.out.println("Quantas Camadas De Queijo Deseja Colocar ");
							int qntdQueijo = teclado.nextInt();
							if(queijo == 1) p += "\nCamadas de Queijo: " + qntdQueijo;
						}
						System.out.println("Deseja Colocar Presunto [1]Sim -- [2]N�o");
						int presunto=teclado.nextInt();
						if(presunto==1) {
							System.out.println("Quantas Camadas De Presunto Deseja Colocar ");
							int qntdPresunto = teclado.nextInt();
							if(presunto == 1) p += "\nCamadas de Presunto: " + qntdPresunto;
						}
						System.out.println("Deseja Colocar Ovo [1]Sim -- [2]N�o");
						int ovo=teclado.nextInt();
						if(ovo==1) {
							System.out.println("Quantas Camadas De Ovo Deseja Colocar ");
							int qntdOvo = teclado.nextInt();
							if(ovo == 1) p += "\nCamadas de Ovo: " + qntdOvo;
						}
						System.out.println("Deseja Colocar Frango [1]Sim -- [2]N�o");
						int frango=teclado.nextInt();
						if(frango==1) {
							System.out.println("Quantas Camadas De Frango Deseja Colocar ");
							int qntdFrango = teclado.nextInt();
							if(frango == 1) p += "\nCamadas de Frango: " + qntdFrango;
						}
					break;
					
				case 2:
					p="Pizza";
					break;
					
				case 3:
					p="Salgados";
					break;
			}
			System.out.println(p);
			System.out.println("seu Pedido esta correto " + nameCliente + " [1]sim -- [2]n�o");
			int resposta = teclado.nextInt();
			if(resposta==1)System.out.println("Deseja Fazer Outro Pedido ? [1]sim -- [2]nao");
			int respo = teclado.nextInt();
			if(respo == 1){endPedido=true;} else {endPedido=false;}
		//Pratos pedido = new Pratos(p,nameCliente);
		}while(endPedido);
		
		teclado.close();
	}
	
	public static void limpatela() throws IOException, InterruptedException {
		try{
            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
		}catch(Exception e) {
			System.out.println(e.getMessage());
		}
	}
	
}