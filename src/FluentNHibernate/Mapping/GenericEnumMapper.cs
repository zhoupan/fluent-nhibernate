﻿using System;
using NHibernate.Type;

namespace FluentNHibernate.Mapping;

[Obsolete("Please use EnumStringType<T> instead")]
[Serializable]
public class GenericEnumMapper<TEnum> : EnumStringType
{
    public GenericEnumMapper()
        : base(typeof(TEnum))
    {
    }
}
