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
            
            //Retiramos todos los caracteres especiales de la frase que puso el usuario.
            string _message_received = message_received.Replace(",", "");
            _message_received = _message_received.Replace(".", "");
            _message_received = _message_received.Replace(":", "");
            _message_received = _message_received.Replace(";", "");
            _message_received = _message_received.Replace("¿", "");
            _message_received = _message_received.Replace("?", "");
            var array_message = _message_received.Split(' ');

            //Declaramos las preguntas con las respuestas
            string[][] matriz = new string[23][];
            matriz[0] = new string [] {"El apoyo Vales Grandeza es un programa del gobierno de gto, creado para ayudar a la economia de guanajuato en esta contingencia."
            ,"que"
            ,"trata"
            ,"apoyo"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[1] = new string []  {"Los vales tienen el valor de 50 pesos c/u."
            ,"que"
            ,"valor"
            ,"tiene"
            ,"vale"
            ,"vacio"
            ,"vacio"};

            matriz[2] = new string []  {"Los vales tienen el valor de 50 pesos c/u."
            ,"que"
            ,"valor"
            ,"tienen"
            ,"vales"
            ,"vacio"
            ,"vacio"};

            matriz[3] = new string [] {"Se da un paquete de 20 vales."
            ,"cuantos"
            ,"vales"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[4] = new string [] {"Si, puedes solicitar el programa."
            ,"pertenezco"
            ,"otro"
            ,"apoyo"
            ,"puedo"
            ,"aplicar"
            ,"vacio"};

            matriz[5] = new string [] {"Que la persona que recibira el apoyo pertenezca a una Zona Impulso."
            ,"cuales"
            ,"requisitos"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[6] = new string [] {"Tienes que ser mayor de edad, con INE."
            ,"tengo"
            ,"cumplir"
            ,"alguna"
            ,"edad"
            ,"vacio"
            ,"vacio"};

            matriz[7] = new string [] {"Solo ser mayor de edad, pertenecer a una zona impulso y no haber tenido el programa mas de 2 veces."
            ,"tiene"
            ,"restricciones"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[8] = new string [] {"Si, mientras no sea un miembro de familia directa."
            ,"alguien"
            ,"familia"
            ,"pertenece"
            ,"programa"
            ,"puedo"
            ,"aplicar"};

            matriz[9] = new string [] {"Comercios como abarrotes, verdulerias, carnicerias y farmacias ISSE."
            ,"cuales"
            ,"comercios"
            ,"participantes"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[10] = new string [] {"Comercios como abarrotes, verdulerias, carnicerias y farmacias ISSE."
            ,"que"
            ,"comercios"
            ,"participan"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[11] = new string [] {"Los requisitos son: ser una tienda o negocio de caracter local."
            ,"cuales"
            ,"requisitos"
            ,"inscribir"
            ,"negocio"
            ,"vacio"
            ,"vacio"};

            matriz[12] = new string [] {"Los requisitos son: ser una tienda o negocio de caracter local."
            ,"que"
            ,"requisitos"
            ,"inscribir"
            ,"negocio"
            ,"vacio"
            ,"vacio"};

            matriz[13] = new string [] {"Si su negocio no cuenta con regristro en hacienda, si puede solicitar el programa."
            ,"negocio"
            ,"no"
            ,"registrado"
            ,"puedo"
            ,"solicitar"
            ,"vacio"};

            matriz[14] = new string [] {"Cada 2 meses."
            ,"cuanto"
            ,"tiempo"
            ,"convocatoria"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[15] = new string [] {"Este programa estara disponible hasta el termino de la contingencia."
            ,"cuanto"
            ,"tiempo"
            ,"disponible"
            ,"programa"
            ,"vacio"
            ,"vacio"};

            matriz[16] = new string [] {"Si, el programa sera otorgado siempre y cuando no haya sido beneficiado mas de 2 veces."
            ,"puedo"
            ,"volver"
            ,"solicitarlo"
            ,"vacio"
            ,"vacio"
            ,"vacio"};


            matriz[17] = new string [] {"Si, el programa sera otorgado siempre y cuando no haya sido beneficiado mas de 2 veces."
            ,"puedo"
            ,"volver"
            ,"solicitar"
            ,"programa"
            ,"vacio"
            ,"vacio"};

            matriz[18] = new string [] {"Si, se repondran aunque los vales perdidos seran cancelados y sin valor alguno."
            ,"pierden"
            ,"vales"
            ,"pueden"
            ,"reembolsar"
            ,"vacio"
            ,"vacio"};

            matriz[19] = new string [] {"Si fuiste aceptado, tu articulador te notificara cuando sera la entrega de tus vales."
            ,"cuando"
            ,"recibire"
            ,"vales"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[20] = new string [] {"De nada, tenga un lindo dia."
            ,"gracias"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[21] = new string [] {"Buenas tardes, ¿En que puedo ayudarte?."
            ,"Hola"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            matriz[22] = new string [] {"Si, se repondran aunque los vales perdidos seran cancelados y sin valor alguno."
            ,"pierdo"
            ,"vales"
            ,"reembolsar"
            ,"vacio"
            ,"vacio"
            ,"vacio"};

            List<int> array_match = new List<int>();
            int indice = 1;
            foreach (var item in array_message)
            {
                int elementos_en_pila = array_match.Count;
                
                //Se necesita una bandera para que solo la primera vez pase en el for de abajo,
                //despues solo busque la palabra en otro for donde se itere la matriz[matchs]
                //Y cuando un indice match vuelva a tener match con otra palabra clave,
                // entonces se agregara otra vez a la pila de matchs.

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
                    //Se usa un for para iterar en los indices 
                    //de los que si hicieron match, ya que 
                    //ahora solo se buscara en los arreglos 
                    //que hicieron match con la primera palabra clave

                    //Nota: Si llenamos un array de los numeros de los indices
                    //con los mas repetidos, es mas facil determinar cual es la respuesta.

                    
                    int[] array_match_temporal= new int[array_match.Count];
                    array_match.CopyTo(array_match_temporal,0);

                    for (int i = 0; i < array_match_temporal.Length; i++)
                    {
                        if(String.Equals(matriz[array_match_temporal[i]][indice], item, StringComparison.CurrentCultureIgnoreCase)){
                            array_match.Add(array_match_temporal[i]);
                        }
                    }

                }
                if(indice==6){
                    break;
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
