using System;
using System.Collections;
using System.Collections.Generic;
namespace XUtils.Ioc
{
	public interface IServicesImplementationCollection : ITypeCollection, IEnumerable<Type>, IEnumerable
	{
	}
}
