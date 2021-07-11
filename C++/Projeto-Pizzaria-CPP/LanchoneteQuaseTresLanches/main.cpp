#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <conio.h>

#include "Cliente.cpp"

using namespace std;

void topo();
void iniciarPedido();

int main(){
    string nome; int tipoPedido{0}; bool pedidoCerto{true};
    topo();
    iniciarPedido();
    system("pause");

    topo();
    cout << "Para Criacao Do Pedido Registre Um Nome Para Entrega: ";
    cin >> nome;

    /*topo();
    cout << "Escolha o Tipo De Seu Pedido\n[1]Lanches -- [2]Pizza -- [3]Salgados";
    tipoPedido = getch();*/

    return 0;
}

void topo(){
    system("cls");
    cout << "----------------------------------------\n";
    cout <<            "Pizzaria 3 Irmaos\n";
    cout << "----------------------------------------\n";
}

void iniciarPedido(){
    cout << "Ola, Seja Bem Vindo A Lanchonete Quase 3 Lanches...\n";
    cout << "Esperamos que fique feliz com nosso cardapio virtual...\n";
    cout << "Sinta se livre e monte seu proprio combo com suas proprias escolhas...\n";
}

void fechamentoPedido(){
    cout << "Obrigado Por ter comprado com a gente, esperamos que fique satisfeito...\n";
    cout << "Volte Sempre...\n";
}