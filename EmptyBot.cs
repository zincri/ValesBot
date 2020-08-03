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
            var array_message = message_received.Split(' ');

            //string[,] matriz = new string[2,4];
            string[][] matriz = new string[2][];
            matriz[0] = new string [] {"El apoyo Vales grandeza es un programa del gobierno de gto.",
            "que",
            "trata",
            "apoyo"};
/*             matriz[1,0] = "Los vales tienen el valor de 50 pesos c/u.";
            matriz[1,1] = "que";
            matriz[1,2] = "valor";
            matriz[1,3] = "tiene";
            matriz[1,3] = "vale"; */

            int contador=0;
            foreach (var item in array_message)
            {
                var x = matriz[0];
                foreach (var words in matriz)
                {
                    Console.Write(words);
                    /* foreach (var word in words)
                    {
                        if(String.Equals(word, item, StringComparison.CurrentCultureIgnoreCase)){

                        }
                    }  */
                    
                    
                } 
                
            }            
            await turnContext.SendActivityAsync($"El usuario dijo: {message_received}",cancellationToken: cancellationToken);
        }
        

        
    }
}
