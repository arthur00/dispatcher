/*
 * -----------------------------------------------------------------
 * Copyright (c) 2012 Intel Corporation
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are
 * met:
 * 
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 * 
 *     * Redistributions in binary form must reproduce the above
 *       copyright notice, this list of conditions and the following
 *       disclaimer in the documentation and/or other materials provided
 *       with the distribution.
 * 
 *     * Neither the name of the Intel Corporation nor the names of its
 *       contributors may be used to endorse or promote products derived
 *       from this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
 * "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
 * A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE INTEL OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
 * EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * EXPORT LAWS: THIS LICENSE ADDS NO RESTRICTIONS TO THE EXPORT LAWS OF
 * YOUR JURISDICTION. It is licensee's responsibility to comply with any
 * export regulations applicable in licensee's jurisdiction. Under
 * CURRENT (May 2000) U.S. export regulations this software is eligible
 * for export from the U.S. and can be downloaded by or otherwise
 * exported or reexported worldwide EXCEPT to U.S. embargoed destinations
 * which include Cuba, Iraq, Libya, North Korea, Iran, Syria, Sudan,
 * Afghanistan and any other country to which the U.S. has embargoed
 * goods and services.
 * -----------------------------------------------------------------
 */

using Mono.Addins;

using System;
using System.Text;

using log4net;
using OpenMetaverse;
using OpenMetaverse.StructuredData;

using OpenSim.Framework;

using Dispatcher;
using Dispatcher.Messages;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RemoteControl.Messages
{
    [JsonObject(MemberSerialization=MemberSerialization.OptIn)]
    public class GetTerrainHeightRequest : Dispatcher.Messages.RequestBase
    {
        [JsonProperty]
        public int X;
        
        [JsonProperty]
        public int Y;
        
        public GetTerrainHeightRequest()
        {
            X = 0;
            Y = 0;
        }
    }

    [JsonObject(MemberSerialization=MemberSerialization.OptIn)]
    public class SetTerrainHeightRequest : Dispatcher.Messages.RequestBase
    {
        [JsonProperty]
        public int X;
        
        [JsonProperty]
        public int Y;

        [JsonProperty]
        public float Height;

        public SetTerrainHeightRequest()
        {
            X = 0;
            Y = 0;
            Height = 20.0f;
        }
    }

    [JsonObject(MemberSerialization=MemberSerialization.OptIn)]
    public class TerrainHeightResponse : Dispatcher.Messages.ResponseBase
    {
        [JsonProperty]
        public int X;
        
        [JsonProperty]
        public int Y;

        [JsonProperty]
        public double Height;

        public TerrainHeightResponse(int x, int y, double h) : base(ResponseCode.Success,"")
        {
            X = x;
            Y = y;
            Height = h;
        }
    }

}


