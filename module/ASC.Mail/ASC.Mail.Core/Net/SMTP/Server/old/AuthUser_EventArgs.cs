/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System;
using LumiSoft.Net;

namespace LumiSoft.Net.SMTP.Server
{
	/// <summary>
	/// Provides data for the AuthUser event for POP3_Server and SMTP_Server.
	/// </summary>
	public class AuthUser_EventArgs
	{
		private SMTP_Session m_pSession   = null;
		private string       m_UserName   = "";
		private string       m_PasswData  = "";
		private string       m_Data       = "";
		private AuthType     m_AuthType;
		private bool         m_Validated  = true;
		private string       m_ReturnData = "";

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <param name="session">Reference to pop3 session.</param>
		/// <param name="userName">Username.</param>
		/// <param name="passwData">Password data.</param>
		/// <param name="data">Authentication specific data(as tag).</param>
		/// <param name="authType">Authentication type.</param>
		public AuthUser_EventArgs(SMTP_Session session,string userName,string passwData,string data,AuthType authType)
		{
			m_pSession  = session;
			m_UserName  = userName;
			m_PasswData = passwData;
			m_Data      = data;
			m_AuthType  = authType;
		}

		#region Properties Implementation

		/// <summary>
		/// Gets reference to smtp session.
		/// </summary>
		public SMTP_Session Session
		{
			get{ return m_pSession; }
		}

		/// <summary>
		/// User name.
		/// </summary>
		public string UserName
		{
			get{ return m_UserName; }
		}

		/// <summary>
		/// Password data. eg. for AUTH=PLAIN it's password and for AUTH=APOP it's md5HexHash.
		/// </summary>
		public string PasswData
		{
			get{ return m_PasswData; }
		}

		/// <summary>
		/// Authentication specific data(as tag).
		/// </summary>
		public string AuthData
		{
			get{ return m_Data; }
		}

		/// <summary>
		/// Authentication type.
		/// </summary>
		public AuthType AuthType
		{
			get{ return m_AuthType; }
		}

		/// <summary>
		/// Gets or sets if user is valid.
		/// </summary>
		public bool Validated
		{
			get{ return m_Validated; }

			set{ m_Validated = value; }
		}

		/// <summary>
		/// Gets or sets authentication data what must be returned for connected client.
		/// </summary>
		public string ReturnData
		{
			get{ return m_ReturnData; }

			set{ m_ReturnData = value; }
		}

		#endregion

	}
}