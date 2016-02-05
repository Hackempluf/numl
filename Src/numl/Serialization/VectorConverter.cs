﻿using System;
using System.Linq;
using System.Reflection;
using numl.Math.LinearAlgebra;
using System.Collections.Generic;
using System.IO;

namespace numl.Serialization
{
    public class VectorSerializer : ISerializer
    {
        public bool CanConvert(Type type)
        {
            return typeof(Vector).IsAssignableFrom(type);
        }

        public object Deserialize(TextReader reader)
        {
            var o = Serializer.Parse(reader);

            return o;
        }

        public void Write(TextWriter writer, object value)
        {
            if (value == null)
                writer.WriteNull();
            else
                Serializer.Write(writer, ((Vector)value).ToArray());
        }
    }
}
