grammar AcmeMath;

expression
	: 'true'														# boolean
	| 'false'														# boolean
	| obj															# json
	| arr															# json
	| '?' STRING													# jmespath
	| literal														# jumpLiteral
	| '[' IDENTIFIER ']' literal									# umLiteral
	| functionCall													# call
	| '(' expression ')'											# parenteses
	| expression '[' expression ']'									# subscription
	| expression '.' IDENTIFIER										# attribute
	| '$' (STRING | IDENTIFIER ('/' IDENTIFIER)*)					# getNode
	| ('-' | '+') expression										# sign
	| expression ('*' | '/' | '%') expression						# factor
	| expression '+' expression										# plus
	| expression '-' expression										# minus
	| expression '^' expression										# bitXor
	| expression ('<' | '>' | '<=' | '>=' | '==' | '!=') expression	# comparison
	| ('!' | 'not') expression										# logicNot
	| expression ('and' | '&&') expression							# logicAnd
	| expression ('or' | '||') expression							# logicOr
	;

obj
   : '{' pair (',' pair)* '}'
   | '{' '}'
   ;
 
pair
   : STRING ':' expression
   ;

arr
   : '[' expression (',' expression)* ']'
   | '[' ']'
   ;

argList
	: expression (',' expression)*
	;

functionCall
	: 'alpha' '(' expression ',' expression ')'						# alpha
	| 'beta' '(' expression ')'										# beta
	| 'gamma' '(' ')'												# gamma
	;													

literal
	: STRING
	| INTEGER
	| FLOAT
	| IDENTIFIER
	| CONSTANT
	;

NEWLINE
	: ( '\r'? '\n' | '\r' | '\f') SPACE?
	;

IDENTIFIER
	: [_a-zA-Z][_0-9a-zA-Z]*
	;

CONSTANT
	: 'PI'
	| 'NAN'
	;

STRING
	: '"' STRING_CONTENT* '"'
	| '\'' STRING_CONTENT* '\''
	;
fragment STRING_CONTENT
	: ~[\\\r\n'"]
	| '\\' [abfnrtv'"\\]
	| '\\u' HEX HEX HEX HEX
	;

INTEGER
	: '0' [xX] HEX+
	| DEC+
	| '0' [bB] [01]+
	;

fragment DEC
	: [0-9]
	;

fragment HEX
	: [0-9a-fA-F]
	;

FLOAT
	: DEC? '.' DEC ([eE] [+-] DEC)?
	| DEC [eE] [+-] DEC
	;

SKIP_
	: (SPACE | COMMENT | LINE_JOINING) -> skip
	;

fragment SPACE
	: [ \t]+
	;

fragment COMMENT
	: '#' ~[\r\n]*
	;

fragment LINE_JOINING
	: '\\' SPACE? ('\r\n' | [\r\n])
	;