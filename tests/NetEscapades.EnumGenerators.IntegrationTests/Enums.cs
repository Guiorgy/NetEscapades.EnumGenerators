using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace System
{
    using NetEscapades.EnumGenerators;

    [EnumExtensions]
    public enum EnumInSystem
    {
        First = 0,
        Second = 1,
        Third = 2,
    }
}

namespace Foo
{
    using NetEscapades.EnumGenerators;

    // causes Error CS0426 : The type name 'TestEnum' does not exist in the type 'Foo'.
    // workaround is to use global prefix 

    public class Foo
    {
    }

    [EnumExtensions]
    public enum EnumInFoo
    {
        First = 0,
        Second = 1,
        Third = 2,
    }
}

namespace NetEscapades.EnumGenerators.IntegrationTests
{
    [EnumExtensions]
    public enum EnumInNamespace
    {
        First = 0,
        Second = 1,
        Third = 2,
    }
    
    [EnumExtensions]
    public enum EnumWithDisplayNameInNamespace
    {
        First = 0,

        [Display(Name = "2nd")]
        Second = 1,

        Third = 2,
    }

    [EnumExtensions]
    public enum EnumWithDescriptionInNamespace
    {
        First = 0,

        [Description("2nd")]
        Second = 1,

        Third = 2,
    }

    [EnumExtensions]
    public enum EnumWithSameDisplayName
    {
        First = 0,

        [Display(Name = "2nd")]
        Second = 1,

        [Display(Name = "2nd")]
        Third = 2,
    }

    [EnumExtensions]
    public enum LongEnum: long
    {
        First = 0,
        Second = 1,
        Third = 2,
    }

    [EnumExtensions]
    [Flags]
    public enum FlagsEnum
    {
        First = 1 << 0,
        Second = 1 << 1,
        Third = 1 << 2,
        Fourth = 1 << 3,
        ThirdAndFourth = Third | Fourth,
    }

    public enum StringTesting
    {
        [System.ComponentModel.Description("Quotes \"")]   Quotes,
        [System.ComponentModel.Description(@"Literal Quotes """)]   LiteralQuotes,
        [System.ComponentModel.Description("Backslash \\")]   Backslash,
        [System.ComponentModel.Description(@"LiteralBackslash \")]   BackslashLiteral,
    }
}