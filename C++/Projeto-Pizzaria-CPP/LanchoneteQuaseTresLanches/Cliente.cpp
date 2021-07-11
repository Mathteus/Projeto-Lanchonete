#include <iostream>
#include <cstdlib>

#include "Pizza.h"
#include <fstream>
#include <ctime>
#include <vector>
#include <memory>
#include <map>

using namespace std;

class Pedidos{
    private:
        string name;
        vector<shared_ptr<Pizza>> pedidos; ifstream arquivoE; ofstream arquivoS;
        vector<map<string,string>> identificador;
        void abrirPedido(){
            arquivoE.open("pedidosSalvos.txt");
            arquivoE.close();
        }
        void salvarPedido(){
            arquivoS.open("pedidosSalvos.txt");

            arquivoS.close();
        }

    public:
        Pedidos(string nome):name(nome){
            this->name=nome;
            pedidos.push_back();
        }
        void cardapio(){
            cout << "       pizzas\n";
            for(int c=0;c<3;c++){
                cout << "Pizza : " << identificador[c].first << "Descrecao: " <<
                identificador[c].second << endl;
            }
        }
};



