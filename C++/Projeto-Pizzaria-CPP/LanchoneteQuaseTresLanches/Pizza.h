#ifndef PIZZA_H_INCLUDED
#define PIZZA_H_INCLUDED

#include <vector>
#include <map>
#include <iostream>
#include <utility>

using namespace std;

class Pizza{
    private:
        string borda, molho, recheio, comum;
        double calcularPreco();
        int total_pizzas{3};
        map<string,string> identificador;
        vector<map<string,string>> id;
        
    public:
        Pizza(string namePizza){
        }
        Pizza(string namePizza,string borda){
        }
        Pizza(string molho,string borda, string recheio){
        }
        Pizza(){
            iniciar_cardapio();
        }
        void iniciar_cardapio(){
            identificador.push_back(make_pair("Atum","Molho de tomate, atum, mussarela, oregano e azeitonas pretas..."));
            identificador.push_back(make_pair("Casteloes","molho de tomate, mussarela, calabresa, artesanal em fatias e oregano"));
            identificador.push_back(make_pair("Gaiotto","molho de tomate, mussarela ao forno, pesto de tomate seco, parmesao, manjericao e oregano"));
        }

};

#endif
