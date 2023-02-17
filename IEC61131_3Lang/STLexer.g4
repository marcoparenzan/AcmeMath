lexer grammar STLexer;
// Lexer tokens and fragments
fragment A : [aA]; // match either an a or A
fragment B : [bB];
fragment C : [cC];
fragment D : [dD];
fragment E : [eE];
fragment F : [fF];
fragment G : [gG];
fragment H : [hH];
fragment I : [iI];
fragment J : [jJ];
fragment K : [kK];
fragment L : [lL];
fragment M : [mM];
fragment N : [nN];
fragment O : [oO];
fragment P : [pP];
fragment Q : [qQ];
fragment R : [rR];
fragment S : [sS];
fragment T : [tT];
fragment U : [uU];
fragment V : [vV];
fragment W : [wW];
fragment X : [xX];
fragment Y : [yY];
fragment Z : [zZ];

fragment DIGIT     : [0-9];
fragment BIN_DIGIT : [01];
fragment OCT_DIGIT : [0-7];
fragment HEX_DIGIT : [0-9a-fA-F];
fragment DEC_DIGIT : DIGIT;
fragment LETTER    : [a-zA-Z_];
fragment SIGN      : PLUS | MINUS;

//[Keywords]
// Elementary data types:
SINT  : S I N T;
USINT : U S I N T;
INT   : I N T;
UINT  : U I N T;
DINT  : D I N T;
UDINT : U D I N T;
LINT  : L I N T;
ULINT : U L I N T;

REAL  : R E A L;
LREAL : L R E A L;

STRING  : S T R I N G;
WSTRING : W S T R I N G;
CHAR    : C H A R;
WCHAR   : W C H A R;

BOOL  : B O O L;
BYTE  : B Y T E;
WORD  : W O R D;
DWORD : D W O R D;
LWORD : L W O R D;

DATE           : D A T E;
LDATE          : L D A T E;
TIME           : T I M E;
LTIME          : L T I M E;
TIME_OF_DAY    : T I M E '_' O F '_' D A Y;
DATE_AND_TIME  : D A T E '_' A N D '_' T I M E;
TOD            : T O D;
LTOD           : L T O D;
DT             : D T;
LDT            : L D T;
LD             : L D;
LT             : L T;

LTIME_OF_DAY   : L T I M E '_' O F '_' D A Y;
LDATE_AND_TIME : L D A T E '_' A N D '_' T I M E;

//constants
FALSE : F A L S E;
TRUE  : T R U E;

UNSIGNED_INT        : DEC_DIGIT (DEC_DIGIT)*;
fragment SIGNED_INT : SIGN? UNSIGNED_INT;

BIN_INT  : '2' SHARP ('_'? BIN_DIGIT)+;
OCT_INT  : '8' SHARP ('_'? OCT_DIGIT)+;
HEX_INT  : '16' SHARP ('_'? HEX_DIGIT)+;
REAL_NUM : SIGNED_INT '.' UNSIGNED_INT ([eE] SIGNED_INT)?;

WSTRING_CONST : '"' .*? '"';
STRING_CONST  : '\'' .*? '\'';

// ST keywords that == ST standard functions Textual operators
OR  : O R;
XOR : X O R;
NOT : N O T;
AND : A N D;
MOD : M O D;

// ST keywords
IF                : I F;
THEN              : T H E N;
ELSE              : E L S E;
ELSIF             : E L S I F;
END_IF            : E N D '_' I F;
WHILE             : W H I L E;
DO                : D O;
END_WHILE         : E N D '_' W H I L E;
REPEAT            : R E P E A T;
UNTIL             : U N T I L;
END_REPEAT        : E N D '_' R E P E A T;
FOR               : F O R;
TO                : T O;
BY                : B Y;
END_FOR           : E N D '_' F O R;
EXIT              : E X I T;
CONTINUE          : C O N T I N U E;
CASE              : C A S E;
END_CASE          : E N D '_' C A S E;
CONFIGURATION     : C O N F I G U R A T I O N;
RESOURCE          : R E S O U R C E;
ON                : O N;
PROGRAM           : P R O G R A M;
END_PROGRAM       : E N D '_' P R O G R A M;
WITH              : W I T H;
TASK              : T A S K;
SINGLE            : S I N G L E;
INTERVAL          : I N T E R V A L;
PRIORITY          : P R I O R I T Y;
VAR_ACCESS        : V A R '_' A C C E S S;
READ_ONLY         : R E A D '_' O N L Y;
READ_WRITE        : R E A D '_' W R I T E;
END_RESOURCE      : E N D '_' R E S O U R C E;
END_CONFIGURATION : E N D '_' C O N F I G U R A T I O N;
SUPER             : S U P E R;
RETURN            : R E T U R N;
VAR_CONFIG        : V A R '_' C O N F I G;
NAMESPACE         : N A M E S P A C E;
INTERNAL          : I N T E R N A L;
PUBLIC            : P U B L I C;
PROTECTED         : P R O T E C T E D;
PRIVATE           : P R I V A T E;
END_NAMESPACE     : E N D '_' N A M E S P A C E;
USING             : U S I N G;
CLASS             : C L A S S;
FINAL             : F I N A L;
ABSTRACT          : A B S T R A C T;
EXTENDS           : E X T E N D S;
IMPLEMENTS        : I M P L E M E N T S;
END_CLASS         : E N D '_' C L A S S;
INTERFACE         : I N T E R F A C E;
END_INTERFACE     : E N D '_' I N T E R F A C E;
METHOD            : M E T H O D;
OVERRIDE          : O V E R R I D E;
END_METHOD        : E N D '_' M E T H O D;

AT                 : A T;
TYPE               : T Y P E;
ENDTYPE            : E N D T Y P E;
ARRAY              : A R R A Y;
OF                 : O F;
STRUCT             : S T R U C T;
ENDSTRUCT          : E N D S T R U C T;
OVERLAP            : O V E R L A P;
REF                : R E F;
REF_TO             : R E F '_' T O;
NULL               : N U L L;
RETAIN             : R E T A I N;
NON_RETAIN         : N O N '_' R E T A I N;
THIS               : T H I S;
CONSTANT           : C O N S T A N T;
VAR                : V A R;
VAR_TEMP           : V A R '_' T E M P;
VAR_GLOBAL         : V A R '_' G L O B A L;
VAR_EXTERNAL       : V A R '_' E X T E R N A L;
VAR_IN_OUT         : V A R '_' I N '_' O U T;
VAR_INPUT          : V A R '_' I N P U T;
VAR_OUTPUT         : V A R '_' O U T P U T;
END_VAR            : E N D '_' V A R;
F_EDGE             : F '_' E D G E;
R_EDGE             : R '_' E D G E;
FUNCTION           : F U N C T I O N;
END_FUNCTION       : E N D '_' F U N C T I O N;
FUNCTION_BLOCK     : F U N C T I O N '_' B L O C K;
END_FUNCTION_BLOCK : E N D '_' F U N C T I O N '_' B L O C K;

// CodeSys support extension
POINTER            : P O I N T E R;

//check underscores
IDENTIFIER : LETTER (LETTER | DIGIT)*;

//Rest
EXPT : '**';
RANGE: '..';
ASSIGN     : ':=';
TRY_ASSIGN : '?=';
MOVE_OUT   : '=>';
NE_SIGN   : '<>';
LE_SIGN: '<=';
GE_SIGN: '>=';
EQ_SIGN        : '=';
LT_SIGN : '<';
GT_SIGN : '>';

DEREF:'^';
PLUS       : '+';
MINUS      : '-';
LBRACK     : '[';
RBRACK     : ']';
SHARP      : '#';
DOT        : '.';
COMMA      : ',';
AMP        : '&';
PERCENT    : '%';
MUL_SIGN: '*';
DIV: '/';
LPAREN : '(';
RPAREN : ')';
COLON: ':';
SCOLON: ';';

WS              : [ \t\r\n] -> skip;
LINE_COMMENT    : '//' ~[\r\n]* -> skip;
BLOCK_COMMENT_1 : '(*' .*? '*)' -> skip;
BLOCK_COMMENT_2 : '/*' .*? '*/' -> skip;


