//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Test.Implementation
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Test.Interfaces;
    using Orleans.CodeGeneration;
    using Orleans;
    using Orleans.EventSourcing;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Test.Implementation.Test.Implementation.Person")]
    public class PersonState : global::Orleans.CodeGeneration.GrainState, IPersonState
    {
        

            public List<Object> UncommitedEvents { get; set; }

            public Int32 Version { get; set; }

            public String FirstName { get; set; }

            public String LastName { get; set; }

            public GenderType Gender { get; set; }

            public Boolean IsMarried { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("UncommitedEvents", out value)) UncommitedEvents = (List<Object>) value;
                if (values.TryGetValue("Version", out value)) Version = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("FirstName", out value)) FirstName = (String) value;
                if (values.TryGetValue("LastName", out value)) LastName = (String) value;
                if (values.TryGetValue("Gender", out value)) Gender = (GenderType) value;
                if (values.TryGetValue("IsMarried", out value)) IsMarried = (Boolean) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("PersonState( UncommitedEvents={0} Version={1} FirstName={2} LastName={3} Gender={4} IsMarried={5} )", UncommitedEvents, Version, FirstName, LastName, Gender, IsMarried);
            }
        
        public PersonState() : 
                base("Test.Implementation.Person")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["UncommitedEvents"] = this.UncommitedEvents;
            result["Version"] = this.Version;
            result["FirstName"] = this.FirstName;
            result["LastName"] = this.LastName;
            result["Gender"] = this.Gender;
            result["IsMarried"] = this.IsMarried;
            return result;
        }
        
        private void InitStateFields()
        {
            this.UncommitedEvents = new List<Object>();
            this.Version = default(Int32);
            this.FirstName = default(String);
            this.LastName = default(String);
            this.Gender = default(GenderType);
            this.IsMarried = default(Boolean);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            PersonState input = ((PersonState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            PersonState input = ((PersonState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            PersonState result = new PersonState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif