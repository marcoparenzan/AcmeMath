// Generated from e:\repos\AcmeMath\AcmeMathLanguage\AcmeMath.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class AcmeMathParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, NEWLINE=35, IDENTIFIER=36, CONSTANT=37, 
		STRING=38, INTEGER=39, FLOAT=40, SKIP_=41;
	public static final int
		RULE_expression = 0, RULE_obj = 1, RULE_pair = 2, RULE_arr = 3, RULE_argList = 4, 
		RULE_functionCall = 5, RULE_literal = 6;
	private static String[] makeRuleNames() {
		return new String[] {
			"expression", "obj", "pair", "arr", "argList", "functionCall", "literal"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'true'", "'false'", "'?'", "'('", "')'", "'['", "']'", "'.'", 
			"'$'", "'/'", "'-'", "'+'", "'*'", "'%'", "'^'", "'<'", "'>'", "'<='", 
			"'>='", "'=='", "'!='", "'!'", "'not'", "'and'", "'&&'", "'or'", "'||'", 
			"'{'", "','", "'}'", "':'", "'alpha'", "'beta'", "'gamma'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, null, "NEWLINE", 
			"IDENTIFIER", "CONSTANT", "STRING", "INTEGER", "FLOAT", "SKIP_"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "AcmeMath.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public AcmeMathParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ExpressionContext extends ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	 
		public ExpressionContext() { }
		public void copyFrom(ExpressionContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class MinusContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public MinusContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class JumpLiteralContext extends ExpressionContext {
		public LiteralContext literal() {
			return getRuleContext(LiteralContext.class,0);
		}
		public JumpLiteralContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class ComparisonContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public ComparisonContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class LogicOrContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public LogicOrContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class SignContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public SignContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class SubscriptionContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public SubscriptionContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class PlusContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public PlusContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class JmespathContext extends ExpressionContext {
		public TerminalNode STRING() { return getToken(AcmeMathParser.STRING, 0); }
		public JmespathContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class CallContext extends ExpressionContext {
		public TerminalNode IDENTIFIER() { return getToken(AcmeMathParser.IDENTIFIER, 0); }
		public ArgListContext argList() {
			return getRuleContext(ArgListContext.class,0);
		}
		public CallContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class LogicAndContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public LogicAndContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class BooleanContext extends ExpressionContext {
		public BooleanContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class ParentesesContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public ParentesesContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class BitXorContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public BitXorContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class JsonContext extends ExpressionContext {
		public ObjContext obj() {
			return getRuleContext(ObjContext.class,0);
		}
		public ArrContext arr() {
			return getRuleContext(ArrContext.class,0);
		}
		public JsonContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class GetNodeContext extends ExpressionContext {
		public TerminalNode STRING() { return getToken(AcmeMathParser.STRING, 0); }
		public List<TerminalNode> IDENTIFIER() { return getTokens(AcmeMathParser.IDENTIFIER); }
		public TerminalNode IDENTIFIER(int i) {
			return getToken(AcmeMathParser.IDENTIFIER, i);
		}
		public GetNodeContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class AttributeContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public TerminalNode IDENTIFIER() { return getToken(AcmeMathParser.IDENTIFIER, 0); }
		public AttributeContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class FactorContext extends ExpressionContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public FactorContext(ExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class LogicNotContext extends ExpressionContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public LogicNotContext(ExpressionContext ctx) { copyFrom(ctx); }
	}

	public final ExpressionContext expression() throws RecognitionException {
		return expression(0);
	}

	private ExpressionContext expression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 0;
		enterRecursionRule(_localctx, 0, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(47);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
			case 1:
				{
				_localctx = new BooleanContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(15);
				match(T__0);
				}
				break;
			case 2:
				{
				_localctx = new BooleanContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(16);
				match(T__1);
				}
				break;
			case 3:
				{
				_localctx = new JsonContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(17);
				obj();
				}
				break;
			case 4:
				{
				_localctx = new JsonContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(18);
				arr();
				}
				break;
			case 5:
				{
				_localctx = new JmespathContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(19);
				match(T__2);
				setState(20);
				match(STRING);
				}
				break;
			case 6:
				{
				_localctx = new JumpLiteralContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(21);
				literal();
				}
				break;
			case 7:
				{
				_localctx = new CallContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(22);
				match(IDENTIFIER);
				setState(23);
				match(T__3);
				setState(24);
				argList();
				setState(25);
				match(T__4);
				}
				break;
			case 8:
				{
				_localctx = new ParentesesContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(27);
				match(T__3);
				setState(28);
				expression(0);
				setState(29);
				match(T__4);
				}
				break;
			case 9:
				{
				_localctx = new GetNodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(31);
				match(T__8);
				setState(41);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case STRING:
					{
					setState(32);
					match(STRING);
					}
					break;
				case IDENTIFIER:
					{
					setState(33);
					match(IDENTIFIER);
					setState(38);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
					while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
						if ( _alt==1 ) {
							{
							{
							setState(34);
							match(T__9);
							setState(35);
							match(IDENTIFIER);
							}
							} 
						}
						setState(40);
						_errHandler.sync(this);
						_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 10:
				{
				_localctx = new SignContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(43);
				_la = _input.LA(1);
				if ( !(_la==T__10 || _la==T__11) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(44);
				expression(9);
				}
				break;
			case 11:
				{
				_localctx = new LogicNotContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(45);
				_la = _input.LA(1);
				if ( !(_la==T__21 || _la==T__22) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				setState(46);
				expression(3);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(80);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,4,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(78);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
					case 1:
						{
						_localctx = new FactorContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(49);
						if (!(precpred(_ctx, 8))) throw new FailedPredicateException(this, "precpred(_ctx, 8)");
						setState(50);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__9) | (1L << T__12) | (1L << T__13))) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(51);
						expression(9);
						}
						break;
					case 2:
						{
						_localctx = new PlusContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(52);
						if (!(precpred(_ctx, 7))) throw new FailedPredicateException(this, "precpred(_ctx, 7)");
						setState(53);
						match(T__11);
						setState(54);
						expression(8);
						}
						break;
					case 3:
						{
						_localctx = new MinusContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(55);
						if (!(precpred(_ctx, 6))) throw new FailedPredicateException(this, "precpred(_ctx, 6)");
						setState(56);
						match(T__10);
						setState(57);
						expression(7);
						}
						break;
					case 4:
						{
						_localctx = new BitXorContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(58);
						if (!(precpred(_ctx, 5))) throw new FailedPredicateException(this, "precpred(_ctx, 5)");
						setState(59);
						match(T__14);
						setState(60);
						expression(6);
						}
						break;
					case 5:
						{
						_localctx = new ComparisonContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(61);
						if (!(precpred(_ctx, 4))) throw new FailedPredicateException(this, "precpred(_ctx, 4)");
						setState(62);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << T__19) | (1L << T__20))) != 0)) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(63);
						expression(5);
						}
						break;
					case 6:
						{
						_localctx = new LogicAndContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(64);
						if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
						setState(65);
						_la = _input.LA(1);
						if ( !(_la==T__23 || _la==T__24) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(66);
						expression(3);
						}
						break;
					case 7:
						{
						_localctx = new LogicOrContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(67);
						if (!(precpred(_ctx, 1))) throw new FailedPredicateException(this, "precpred(_ctx, 1)");
						setState(68);
						_la = _input.LA(1);
						if ( !(_la==T__25 || _la==T__26) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(69);
						expression(2);
						}
						break;
					case 8:
						{
						_localctx = new SubscriptionContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(70);
						if (!(precpred(_ctx, 12))) throw new FailedPredicateException(this, "precpred(_ctx, 12)");
						setState(71);
						match(T__5);
						setState(72);
						expression(0);
						setState(73);
						match(T__6);
						}
						break;
					case 9:
						{
						_localctx = new AttributeContext(new ExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_expression);
						setState(75);
						if (!(precpred(_ctx, 11))) throw new FailedPredicateException(this, "precpred(_ctx, 11)");
						setState(76);
						match(T__7);
						setState(77);
						match(IDENTIFIER);
						}
						break;
					}
					} 
				}
				setState(82);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,4,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class ObjContext extends ParserRuleContext {
		public List<PairContext> pair() {
			return getRuleContexts(PairContext.class);
		}
		public PairContext pair(int i) {
			return getRuleContext(PairContext.class,i);
		}
		public ObjContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_obj; }
	}

	public final ObjContext obj() throws RecognitionException {
		ObjContext _localctx = new ObjContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_obj);
		int _la;
		try {
			setState(96);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(83);
				match(T__27);
				setState(84);
				pair();
				setState(89);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__28) {
					{
					{
					setState(85);
					match(T__28);
					setState(86);
					pair();
					}
					}
					setState(91);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(92);
				match(T__29);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(94);
				match(T__27);
				setState(95);
				match(T__29);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PairContext extends ParserRuleContext {
		public TerminalNode STRING() { return getToken(AcmeMathParser.STRING, 0); }
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public PairContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pair; }
	}

	public final PairContext pair() throws RecognitionException {
		PairContext _localctx = new PairContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_pair);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(98);
			match(STRING);
			setState(99);
			match(T__30);
			setState(100);
			expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArrContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public ArrContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_arr; }
	}

	public final ArrContext arr() throws RecognitionException {
		ArrContext _localctx = new ArrContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_arr);
		int _la;
		try {
			setState(115);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(102);
				match(T__5);
				setState(103);
				expression(0);
				setState(108);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==T__28) {
					{
					{
					setState(104);
					match(T__28);
					setState(105);
					expression(0);
					}
					}
					setState(110);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(111);
				match(T__6);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(113);
				match(T__5);
				setState(114);
				match(T__6);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArgListContext extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public ArgListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_argList; }
	}

	public final ArgListContext argList() throws RecognitionException {
		ArgListContext _localctx = new ArgListContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_argList);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(117);
			expression(0);
			setState(122);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T__28) {
				{
				{
				setState(118);
				match(T__28);
				setState(119);
				expression(0);
				}
				}
				setState(124);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FunctionCallContext extends ParserRuleContext {
		public FunctionCallContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionCall; }
	 
		public FunctionCallContext() { }
		public void copyFrom(FunctionCallContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class AlphaContext extends FunctionCallContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public AlphaContext(FunctionCallContext ctx) { copyFrom(ctx); }
	}
	public static class BetaContext extends FunctionCallContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public BetaContext(FunctionCallContext ctx) { copyFrom(ctx); }
	}
	public static class GammaContext extends FunctionCallContext {
		public GammaContext(FunctionCallContext ctx) { copyFrom(ctx); }
	}

	public final FunctionCallContext functionCall() throws RecognitionException {
		FunctionCallContext _localctx = new FunctionCallContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_functionCall);
		try {
			setState(140);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__31:
				_localctx = new AlphaContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(125);
				match(T__31);
				setState(126);
				match(T__3);
				setState(127);
				expression(0);
				setState(128);
				match(T__28);
				setState(129);
				expression(0);
				setState(130);
				match(T__4);
				}
				break;
			case T__32:
				_localctx = new BetaContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(132);
				match(T__32);
				setState(133);
				match(T__3);
				setState(134);
				expression(0);
				setState(135);
				match(T__4);
				}
				break;
			case T__33:
				_localctx = new GammaContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(137);
				match(T__33);
				setState(138);
				match(T__3);
				setState(139);
				match(T__4);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LiteralContext extends ParserRuleContext {
		public TerminalNode STRING() { return getToken(AcmeMathParser.STRING, 0); }
		public TerminalNode INTEGER() { return getToken(AcmeMathParser.INTEGER, 0); }
		public TerminalNode FLOAT() { return getToken(AcmeMathParser.FLOAT, 0); }
		public TerminalNode IDENTIFIER() { return getToken(AcmeMathParser.IDENTIFIER, 0); }
		public TerminalNode CONSTANT() { return getToken(AcmeMathParser.CONSTANT, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_literal; }
	}

	public final LiteralContext literal() throws RecognitionException {
		LiteralContext _localctx = new LiteralContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_literal);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(142);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << IDENTIFIER) | (1L << CONSTANT) | (1L << STRING) | (1L << INTEGER) | (1L << FLOAT))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 0:
			return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 8);
		case 1:
			return precpred(_ctx, 7);
		case 2:
			return precpred(_ctx, 6);
		case 3:
			return precpred(_ctx, 5);
		case 4:
			return precpred(_ctx, 4);
		case 5:
			return precpred(_ctx, 2);
		case 6:
			return precpred(_ctx, 1);
		case 7:
			return precpred(_ctx, 12);
		case 8:
			return precpred(_ctx, 11);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3+\u0093\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\3\2\3\2\3\2\3\2\3\2\3\2"+
		"\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\7\2\'"+
		"\n\2\f\2\16\2*\13\2\5\2,\n\2\3\2\3\2\3\2\3\2\5\2\62\n\2\3\2\3\2\3\2\3"+
		"\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2"+
		"\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\7\2Q\n\2\f\2\16\2T\13\2\3\3\3\3\3\3\3"+
		"\3\7\3Z\n\3\f\3\16\3]\13\3\3\3\3\3\3\3\3\3\5\3c\n\3\3\4\3\4\3\4\3\4\3"+
		"\5\3\5\3\5\3\5\7\5m\n\5\f\5\16\5p\13\5\3\5\3\5\3\5\3\5\5\5v\n\5\3\6\3"+
		"\6\3\6\7\6{\n\6\f\6\16\6~\13\6\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7"+
		"\3\7\3\7\3\7\3\7\3\7\5\7\u008f\n\7\3\b\3\b\3\b\2\3\2\t\2\4\6\b\n\f\16"+
		"\2\t\3\2\r\16\3\2\30\31\4\2\f\f\17\20\3\2\22\27\3\2\32\33\3\2\34\35\3"+
		"\2&*\2\u00a7\2\61\3\2\2\2\4b\3\2\2\2\6d\3\2\2\2\bu\3\2\2\2\nw\3\2\2\2"+
		"\f\u008e\3\2\2\2\16\u0090\3\2\2\2\20\21\b\2\1\2\21\62\7\3\2\2\22\62\7"+
		"\4\2\2\23\62\5\4\3\2\24\62\5\b\5\2\25\26\7\5\2\2\26\62\7(\2\2\27\62\5"+
		"\16\b\2\30\31\7&\2\2\31\32\7\6\2\2\32\33\5\n\6\2\33\34\7\7\2\2\34\62\3"+
		"\2\2\2\35\36\7\6\2\2\36\37\5\2\2\2\37 \7\7\2\2 \62\3\2\2\2!+\7\13\2\2"+
		"\",\7(\2\2#(\7&\2\2$%\7\f\2\2%\'\7&\2\2&$\3\2\2\2\'*\3\2\2\2(&\3\2\2\2"+
		"()\3\2\2\2),\3\2\2\2*(\3\2\2\2+\"\3\2\2\2+#\3\2\2\2,\62\3\2\2\2-.\t\2"+
		"\2\2.\62\5\2\2\13/\60\t\3\2\2\60\62\5\2\2\5\61\20\3\2\2\2\61\22\3\2\2"+
		"\2\61\23\3\2\2\2\61\24\3\2\2\2\61\25\3\2\2\2\61\27\3\2\2\2\61\30\3\2\2"+
		"\2\61\35\3\2\2\2\61!\3\2\2\2\61-\3\2\2\2\61/\3\2\2\2\62R\3\2\2\2\63\64"+
		"\f\n\2\2\64\65\t\4\2\2\65Q\5\2\2\13\66\67\f\t\2\2\678\7\16\2\28Q\5\2\2"+
		"\n9:\f\b\2\2:;\7\r\2\2;Q\5\2\2\t<=\f\7\2\2=>\7\21\2\2>Q\5\2\2\b?@\f\6"+
		"\2\2@A\t\5\2\2AQ\5\2\2\7BC\f\4\2\2CD\t\6\2\2DQ\5\2\2\5EF\f\3\2\2FG\t\7"+
		"\2\2GQ\5\2\2\4HI\f\16\2\2IJ\7\b\2\2JK\5\2\2\2KL\7\t\2\2LQ\3\2\2\2MN\f"+
		"\r\2\2NO\7\n\2\2OQ\7&\2\2P\63\3\2\2\2P\66\3\2\2\2P9\3\2\2\2P<\3\2\2\2"+
		"P?\3\2\2\2PB\3\2\2\2PE\3\2\2\2PH\3\2\2\2PM\3\2\2\2QT\3\2\2\2RP\3\2\2\2"+
		"RS\3\2\2\2S\3\3\2\2\2TR\3\2\2\2UV\7\36\2\2V[\5\6\4\2WX\7\37\2\2XZ\5\6"+
		"\4\2YW\3\2\2\2Z]\3\2\2\2[Y\3\2\2\2[\\\3\2\2\2\\^\3\2\2\2][\3\2\2\2^_\7"+
		" \2\2_c\3\2\2\2`a\7\36\2\2ac\7 \2\2bU\3\2\2\2b`\3\2\2\2c\5\3\2\2\2de\7"+
		"(\2\2ef\7!\2\2fg\5\2\2\2g\7\3\2\2\2hi\7\b\2\2in\5\2\2\2jk\7\37\2\2km\5"+
		"\2\2\2lj\3\2\2\2mp\3\2\2\2nl\3\2\2\2no\3\2\2\2oq\3\2\2\2pn\3\2\2\2qr\7"+
		"\t\2\2rv\3\2\2\2st\7\b\2\2tv\7\t\2\2uh\3\2\2\2us\3\2\2\2v\t\3\2\2\2w|"+
		"\5\2\2\2xy\7\37\2\2y{\5\2\2\2zx\3\2\2\2{~\3\2\2\2|z\3\2\2\2|}\3\2\2\2"+
		"}\13\3\2\2\2~|\3\2\2\2\177\u0080\7\"\2\2\u0080\u0081\7\6\2\2\u0081\u0082"+
		"\5\2\2\2\u0082\u0083\7\37\2\2\u0083\u0084\5\2\2\2\u0084\u0085\7\7\2\2"+
		"\u0085\u008f\3\2\2\2\u0086\u0087\7#\2\2\u0087\u0088\7\6\2\2\u0088\u0089"+
		"\5\2\2\2\u0089\u008a\7\7\2\2\u008a\u008f\3\2\2\2\u008b\u008c\7$\2\2\u008c"+
		"\u008d\7\6\2\2\u008d\u008f\7\7\2\2\u008e\177\3\2\2\2\u008e\u0086\3\2\2"+
		"\2\u008e\u008b\3\2\2\2\u008f\r\3\2\2\2\u0090\u0091\t\b\2\2\u0091\17\3"+
		"\2\2\2\r(+\61PR[bnu|\u008e";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}