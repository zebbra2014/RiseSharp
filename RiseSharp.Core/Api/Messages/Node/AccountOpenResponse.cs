﻿#region copyright
// <copyright file="AccountOpenResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;
using RiseSharp.Core.Api.Messages.Common;
using RiseSharp.Core.Api.Models;

namespace RiseSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Response class for handling output from Account open
    /// </summary>
    [DataContract]
    public class OpenAccountResponse : BaseResponse
    {
        [DataMember(Name = "account")]
        public Account Account { get; set; }
    }
}
