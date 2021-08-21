//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from grammar/funscript.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class funscriptParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		HASH=1, BLOCK=2, COLON=3, SQ=4, DQ=5, COMMENT=6, TEXT=7, LITERAL=8, WS=9;
	public const int
		RULE_script = 0, RULE_block = 1, RULE_statement = 2, RULE_sayStatement = 3;
	public static readonly string[] ruleNames = {
		"script", "block", "statement", "sayStatement"
	};

	private static readonly string[] _LiteralNames = {
		null, "'#'", "'block'", "':'", "'''", "'\"'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "HASH", "BLOCK", "COLON", "SQ", "DQ", "COMMENT", "TEXT", "LITERAL", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "funscript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static funscriptParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public funscriptParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public funscriptParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ScriptContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext[] block() {
			return GetRuleContexts<BlockContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public BlockContext block(int i) {
			return GetRuleContext<BlockContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public ScriptContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_script; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.EnterScript(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.ExitScript(this);
		}
	}

	[RuleVersion(0)]
	public ScriptContext script() {
		ScriptContext _localctx = new ScriptContext(Context, State);
		EnterRule(_localctx, 0, RULE_script);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 10;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case BLOCK:
					{
					State = 8;
					block();
					}
					break;
				case COMMENT:
				case TEXT:
				case LITERAL:
					{
					State = 9;
					statement();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 12;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BLOCK) | (1L << COMMENT) | (1L << TEXT) | (1L << LITERAL))) != 0) );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BLOCK() { return GetToken(funscriptParser.BLOCK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL() { return GetToken(funscriptParser.LITERAL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COLON() { return GetToken(funscriptParser.COLON, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 2, RULE_block);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			Match(BLOCK);
			State = 15;
			Match(LITERAL);
			{
			State = 16;
			Match(COLON);
			}
			State = 20;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 17;
					statement();
					}
					} 
				}
				State = 22;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SayStatementContext sayStatement() {
			return GetRuleContext<SayStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMENT() { return GetToken(funscriptParser.COMMENT, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 4, RULE_statement);
		try {
			State = 25;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case TEXT:
			case LITERAL:
				EnterOuterAlt(_localctx, 1);
				{
				State = 23;
				sayStatement();
				}
				break;
			case COMMENT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 24;
				Match(COMMENT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SayStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEXT() { return GetToken(funscriptParser.TEXT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL() { return GetToken(funscriptParser.LITERAL, 0); }
		public SayStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sayStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.EnterSayStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IfunscriptListener typedListener = listener as IfunscriptListener;
			if (typedListener != null) typedListener.ExitSayStatement(this);
		}
	}

	[RuleVersion(0)]
	public SayStatementContext sayStatement() {
		SayStatementContext _localctx = new SayStatementContext(Context, State);
		EnterRule(_localctx, 6, RULE_sayStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 28;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LITERAL) {
				{
				State = 27;
				Match(LITERAL);
				}
			}

			State = 30;
			Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\v', '#', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', '\x2', 
		'\x3', '\x2', '\x6', '\x2', '\r', '\n', '\x2', '\r', '\x2', '\xE', '\x2', 
		'\xE', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', 
		'\x15', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x18', '\v', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', '\x1C', '\n', '\x4', '\x3', '\x5', 
		'\x5', '\x5', '\x1F', '\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x2', '\x2', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x2', '\x2', 
		'#', '\x2', '\f', '\x3', '\x2', '\x2', '\x2', '\x4', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\x1B', '\x3', '\x2', '\x2', '\x2', '\b', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\n', '\r', '\x5', '\x4', '\x3', '\x2', '\v', 
		'\r', '\x5', '\x6', '\x4', '\x2', '\f', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\f', '\v', '\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '\xE', '\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', 
		'\a', '\x4', '\x2', '\x2', '\x11', '\x12', '\a', '\n', '\x2', '\x2', '\x12', 
		'\x16', '\a', '\x5', '\x2', '\x2', '\x13', '\x15', '\x5', '\x6', '\x4', 
		'\x2', '\x14', '\x13', '\x3', '\x2', '\x2', '\x2', '\x15', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '\x16', '\x14', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x17', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x18', '\x16', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1C', '\x5', 
		'\b', '\x5', '\x2', '\x1A', '\x1C', '\a', '\b', '\x2', '\x2', '\x1B', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x1C', '\a', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1F', '\a', 
		'\n', '\x2', '\x2', '\x1E', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\x3', '\x2', '\x2', 
		'\x2', ' ', '!', '\a', '\t', '\x2', '\x2', '!', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\a', '\f', '\xE', '\x16', '\x1B', '\x1E',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
