﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Validation Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.TestSupport.TestClasses
{
	public class DerivedTestTypeWithValidatorAttributesOnMethods : BaseTestTypeWithValidatorAttributesOnMethods
	{
		[MockValidator(false, MessageTemplate = "MethodWithMultipleAttributesOverride-Message1")]
		public override object MethodWithMultipleAttributes()
		{
			return base.MethodWithMultipleAttributes();
		}
	}
}
