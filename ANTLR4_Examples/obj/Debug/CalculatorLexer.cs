//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\SourceCode\�½��ļ���\ANTLR_S\ANTLR_S\Calculator\Calculator.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ANTLR4_Examples.Calculator {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class CalculatorLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, ID=4, INT=5, NEWLINE=6, WS=7, MUL=8, DIV=9, ADD=10, 
		SUB=11;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "ID", "INT", "NEWLINE", "WS", "MUL", "DIV", "ADD", 
		"SUB"
	};


	public CalculatorLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'='", "'('", "')'", null, null, null, null, "'*'", "'/'", "'+'", 
		"'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "ID", "INT", "NEWLINE", "WS", "MUL", "DIV", "ADD", 
		"SUB"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Calculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\r=\b\x1\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3"+
		"\x5\x6\x5!\n\x5\r\x5\xE\x5\"\x3\x6\x6\x6&\n\x6\r\x6\xE\x6\'\x3\a\x5\a"+
		"+\n\a\x3\a\x3\a\x3\b\x6\b\x30\n\b\r\b\xE\b\x31\x3\b\x3\b\x3\t\x3\t\x3"+
		"\n\x3\n\x3\v\x3\v\x3\f\x3\f\x2\x2\x2\r\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2"+
		"\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x3\x2\x5"+
		"\x4\x2\x43\\\x63|\x3\x2\x32;\x4\x2\v\v\"\"@\x2\x3\x3\x2\x2\x2\x2\x5\x3"+
		"\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2"+
		"\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15"+
		"\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x3\x19\x3\x2\x2\x2\x5\x1B\x3\x2\x2\x2"+
		"\a\x1D\x3\x2\x2\x2\t \x3\x2\x2\x2\v%\x3\x2\x2\x2\r*\x3\x2\x2\x2\xF/\x3"+
		"\x2\x2\x2\x11\x35\x3\x2\x2\x2\x13\x37\x3\x2\x2\x2\x15\x39\x3\x2\x2\x2"+
		"\x17;\x3\x2\x2\x2\x19\x1A\a?\x2\x2\x1A\x4\x3\x2\x2\x2\x1B\x1C\a*\x2\x2"+
		"\x1C\x6\x3\x2\x2\x2\x1D\x1E\a+\x2\x2\x1E\b\x3\x2\x2\x2\x1F!\t\x2\x2\x2"+
		" \x1F\x3\x2\x2\x2!\"\x3\x2\x2\x2\" \x3\x2\x2\x2\"#\x3\x2\x2\x2#\n\x3\x2"+
		"\x2\x2$&\t\x3\x2\x2%$\x3\x2\x2\x2&\'\x3\x2\x2\x2\'%\x3\x2\x2\x2\'(\x3"+
		"\x2\x2\x2(\f\x3\x2\x2\x2)+\a\xF\x2\x2*)\x3\x2\x2\x2*+\x3\x2\x2\x2+,\x3"+
		"\x2\x2\x2,-\a\f\x2\x2-\xE\x3\x2\x2\x2.\x30\t\x4\x2\x2/.\x3\x2\x2\x2\x30"+
		"\x31\x3\x2\x2\x2\x31/\x3\x2\x2\x2\x31\x32\x3\x2\x2\x2\x32\x33\x3\x2\x2"+
		"\x2\x33\x34\b\b\x2\x2\x34\x10\x3\x2\x2\x2\x35\x36\a,\x2\x2\x36\x12\x3"+
		"\x2\x2\x2\x37\x38\a\x31\x2\x2\x38\x14\x3\x2\x2\x2\x39:\a-\x2\x2:\x16\x3"+
		"\x2\x2\x2;<\a/\x2\x2<\x18\x3\x2\x2\x2\a\x2\"\'*\x31\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ANTLR4_Examples.Calculator