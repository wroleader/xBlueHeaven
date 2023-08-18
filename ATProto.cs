using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishyFlip;

namespace xBlueHeaven
{
    internal class ATProto
    {
        private readonly string username;
        private readonly string? password;
        readonly ATProtocolBuilder atProtoBuild = new ATProtocolBuilder().EnableAutoRenewSession(true);
        private ATProtocol atP;

        public ATProto(string username, string password) 
        {
            if (username != null)
            {
                this.username = username;
            }
            if (password != null)
            {
                this.password = password;
            }
        }

        public void BuildProtocol()
        {
            atP = atProtoBuild.Build();
        }
    }
}
