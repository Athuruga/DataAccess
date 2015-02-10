﻿using System;
using System.Runtime.Serialization;

namespace iQuarc.DataAccess
{
	[Serializable]
	public class RepositoryUpdateException : RepositoryViolationException
	{
		public RepositoryUpdateException()
		{
		}

		public RepositoryUpdateException(string errorMessage)
			: base(errorMessage)
		{
		}

		public RepositoryUpdateException(Exception exception)
			: base(exception)
		{
		}

		public RepositoryUpdateException(string message, Exception exception)
			: base(message, exception)
		{
		}

		protected RepositoryUpdateException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}