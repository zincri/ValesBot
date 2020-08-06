// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with EmptyBot .NET Template version v4.9.1

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace ValesBot
{
    public class EmptyBot : ActivityHandler
    {
        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Hola mi nombre es Zincri, en que puedo ayudarte?!"), cancellationToken);
                }
            }
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken){
            var message_received = turnContext.Activity.Text;
            //char[] MyChar = {',', '.','¿','?'};
            
            string _message_received = message_received.Replace(",", "");
            _message_received = _message_received.Replace(".", "");
            _message_received = _message_received.Replace("¿", "");
            _message_received = _message_received.Replace("?", "");
            var array_message = _message_received.Split(' ');

            string[][] matriz = new string[2][];
            matriz[0] = new string [] {"El apoyo Vales grandeza es un programa del gobierno de gto."
            ,"que"
            ,"trata"
            ,"apoyo"
            ,"vacio"};

            matriz[1] = new string []  {"Los vales tienen el valor de 50 pesos c/u."
            ,"que"
            ,"valor"
            ,"tiene"
            ,"vale"};

            List<int> array_match = new List<int>();
            int indice = 1;
            foreach (var item in array_message)
            {
                int elementos_en_pila = array_match.Count;
                
                //Se necesita una bandera para que solo la primera vez pase en el for de abajo,
                //despues solo busque la palabra en otro for donde se itere la matriz[matchs]
                //Y cuando un match ya no continue, entonces se eliminara de la pila de matchs,
                //Cuando el array tenga solo un elemento es entonces que encontro el match exacto.

                //Tambien debes validar cuando no haya ningun match y debe buscar en otra palabra(posicion.)
                if (indice==1){
                    int contador=0;
                    foreach (var words in matriz)
                    {
                        if(String.Equals(words[indice], item, StringComparison.CurrentCultureIgnoreCase)){
                            array_match.Add(contador);
                        }
                        contador++;
                    }

                }
                else{
                    //Usar un for para iterar solo 
                    //los que si hicieron match,
                    //Tambien se necesita un contador
                    //para saber que palabra de lo que
                    //ingreso el usuario se esta comparando.

                    //Si llenamos el array de match con los mas repetidos
                    //es mas facil determinar cual es la respuesta
                    int[] array_match_temporal= new int[array_match.Count];
                    array_match.CopyTo(array_match_temporal,0);

                    for (int i = 0; i < array_match_temporal.Length; i++)
                    {
                        if(String.Equals(matriz[array_match_temporal[i]][indice], item, StringComparison.CurrentCultureIgnoreCase)){
                            array_match.Add(array_match_temporal[i]);
                        }
                    }

                }
                if(array_match.Count != elementos_en_pila){
                    indice++;
                }    
            }
            if(array_match.Count==0){
                await turnContext.SendActivityAsync("No encontre informacion suficiente para responder tu pregunta.",cancellationToken: cancellationToken);
            }
            else{
                int numero_veces=0;
                int[,] numeros_repetidos = new int[array_match.Count,2];
                for (int i = 0; i < array_match.Count; i++)
                {
                    for (int j = 0; j < array_match.Count; j++)
                    {
                        if(array_match[i]==array_match[j]){
                            numero_veces += 1;
                        }
                    }
                    numeros_repetidos[i,0]=array_match[i];
                    numeros_repetidos[i,1]=numero_veces;
                    numero_veces=0;

                }
                int mayor,posicion=0;
                mayor=numeros_repetidos[0,1];
                for (int k = 1; k < array_match.Count; k++)
                {
                    if(numeros_repetidos[k,1]> mayor){
                        mayor = numeros_repetidos[k,1];
                        posicion = k;

                    }
                    
                }
                int indice_ = numeros_repetidos[posicion,0];
                int vrep_ = numeros_repetidos[posicion,1];

                await turnContext.SendActivityAsync($"Respuesta: {matriz[indice_][0]}.",cancellationToken: cancellationToken);
            }
            //Una vez que ya termino.
            //el numero que mas se repite en el array de matchs
            //matriz[indice_mas_repetido] es la cadena buscada.
            //entonces matriz[indice_mas_repetido][0] es la respuesta.
                     
        }
        

        
    }
}
