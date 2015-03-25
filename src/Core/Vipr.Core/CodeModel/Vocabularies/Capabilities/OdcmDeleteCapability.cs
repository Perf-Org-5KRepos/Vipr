﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Vipr.Core.CodeModel.Vocabularies.Capabilities
{
    public class OdcmDeleteCapability : OdcmBooleanCapability
    {
        public override string TermName 
        {
            get { return "Org.OData.Capabilities.V1.DeleteRestrictions"; }
        }

        /// <summary>
        /// Entities can be deleted
        /// </summary>
        public bool Deletable
        {
            get { return BooleanValue; }
        }

        public OdcmDeleteCapability()
        {
            BooleanValue = true;
        }

        public override bool Equals(OdcmCapability otherCapability)
        {
            var other = otherCapability as OdcmDeleteCapability;
            if(other == null)
            {
                return false;
            }

            return Deletable == other.Deletable;
         }
    }
}
