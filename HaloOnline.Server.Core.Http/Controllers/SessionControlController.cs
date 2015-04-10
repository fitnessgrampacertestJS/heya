﻿using System.Collections.Generic;
using System.Web.Http;
using HaloOnline.Server.Core.Http.Interface.Services;
using HaloOnline.Server.Core.Http.Model;
using HaloOnline.Server.Core.Http.Model.SessionControl;
using HaloOnline.Server.Model.SessionControl;

namespace HaloOnline.Server.Core.Http.Controllers
{
    public class SessionControlController : ApiController, ISessionControlService
    {
        [HttpPost]
        public ClientGetStatusResult ClientGetStatus(ClientGetStatusRequest request)
        {
            return new ClientGetStatusResult
            {
                Result = new ServiceResult<ClientStatus>
                {
                    Data = new ClientStatus
                    {
                        Game = new Game
                        {
                            Id = "7A0E225D-B2F0-4AD3-BFEA-21404AA29DC3"
                        },
                        DedicatedServer = new DedicatedServer
                        {
                            ServerId = "F461B3D8-C3BC-42B9-AE12-E8A9EBD610CE",
                            ServerAddress = "127.0.0.1",
                            Port = 12345
                        }
                    }
                }
            };
        }

        [HttpPost]
        public GetSessionBasicDataResult GetSessionBasicData(GetSessionBasicDataRequest request)
        {
            return new GetSessionBasicDataResult
            {
                Result = new ServiceResult<List<SessionBasicData>>
                {
                    ReturnCode = 0,
                    Data = new List<SessionBasicData>
                    {
                        new SessionBasicData
                        {
                            SessionId = "614E1ECD-9865-4A5A-905C-EB2984783300",
                            MapId = "C867209D-F0B5-432B-98D9-DA9F9DF07A01",
                            ModeId = "B67CF8BF-B0F2-411F-AAF9-7B165C09E782",
                            Finished = 0,
                            Started = 0
                        }
                    }
                }
            };
        }

        [HttpPost]
        public GetSessionChainResult GetSessionChain(GetSessionChainRequest request)
        {
            return new GetSessionChainResult
            {
                Result = new ServiceResult<List<SessionChain>>
                {
                    Data = new List<SessionChain>
                    {
                        new SessionChain
                        {
                            User = "CEFDB7DA-95A1-4F66-A1D5-529A9081A676",
                            Sessions = new List<Game>
                            {
                                new Game
                                {
                                    Id = "D99A01C5-E9B5-467F-8FBE-E3168F3DE4EC"
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
