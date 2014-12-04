using System;
using System.Data.Entity.Core;
using iQuarc.SystemEx;

namespace iQuarc.DataAccess
{
	internal class RepositoryConcurrencyExceptionHandler : IRepositoryExceptionHandler
	{
		private readonly IRepositoryExceptionHandler successor;

		public RepositoryConcurrencyExceptionHandler(IRepositoryExceptionHandler successor)
		{
			this.successor = successor;
		}

		public void Handle(Exception exception)
		{
			var concurrencyException = exception.FirstInner<OptimisticConcurrencyException>();
			if (concurrencyException != null)
			{
				throw new ConcurrencyRepositoryViolationException(concurrencyException);
			}

			successor.Handle(exception);
		}
	}
}