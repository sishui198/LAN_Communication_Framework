﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ProtocolLibrary.CCProtocol;

using Middleware.Device;
using Middleware.Communication.Message;
using Middleware.Interface;

namespace Middleware.Communication.Package.Internal
{
    public class C2CMessageRadioPackage : C2CRadioPackage, ICCSerializeOperat<CCCommunicateClass.Seria_C2CMessageRadioPackage>
    {
        protected BaseMessage mMessage = null;
        public BaseMessage Message
        {
            get { return mMessage; }
        }

        public C2CMessageRadioPackage(GroupDevice targetDevice, BaseMessage msg)
            : base(targetDevice, "C2CMessageRadioPackage_" + msg.Type.Name, null)
        {
            mMessage = msg;
        }

        public override byte[] SerializeMiddlewareMessage()
        {
            throw new NotImplementedException();
        }

        public new CCCommunicateClass.Seria_C2CMessageRadioPackage ExportSerializeData()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void ParseSerializeData(CCCommunicateClass.Seria_C2CMessageRadioPackage obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
