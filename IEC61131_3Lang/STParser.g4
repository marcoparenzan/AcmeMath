parser grammar STParser;
options {
    tokenVocab = STLexer;
}

translationUnitDecl: (pouDecl | namespaceDecl | configDecl)+;

// Parser rules Table 71 - 72 - Language Structured Text (ST)
expression   : xorExpr ( OR xorExpr)*;
constantExpr : expression;
xorExpr      : andExpr ( XOR andExpr)*;
andExpr      : compareExpr (( AMP | AND) compareExpr)*;
compareExpr  : equExpr (( EQ_SIGN | NE_SIGN) equExpr)*;
equExpr      : addExpr (( LT_SIGN | GT_SIGN | LE_SIGN | GE_SIGN) addExpr)*;
addExpr      : term (( PLUS | MINUS) term)*;
term         : powerExpr ( (MUL_SIGN | DIV | MOD) powerExpr)*;
powerExpr    : unaryExpr ( EXPT unaryExpr)*;
unaryExpr    : (MINUS | PLUS | NOT)? primaryExpr;
primaryExpr:
    constant
    | enumValue
    | variableAccess
    | funcCall
    | refValue
    | LPAREN expression RPAREN;

variableAccess : variable multibitPartAccess?;

multibitPartAccess : DOT ( unsignedInt | PERCENT localAtType? unsignedInt);
funcCall           : funcAccess LPAREN (paramAssign ( COMMA paramAssign)*)? RPAREN;
stmtList           : ( stmt? SCOLON)+;
stmt               : assignStmt | subprogCtrlStmt | selectionStmt | iterationStmt;
assignStmt         : (variableAccess ASSIGN expression) | refAssign | assignmentAttempt;
assignmentAttempt: (refName | refDeref) TRY_ASSIGN (
        refName
        | refDeref
        | refValue
    );
invocation: (
        fBInstanceName
        | methodName
        | THIS
        | (
            (THIS DOT)? (( ( fBInstanceName | classInstanceName) DOT)+) methodName
        )
    ) LPAREN (paramAssign ( COMMA paramAssign)*)? RPAREN;
subprogCtrlStmt : funcCall | invocation | SUPER LPAREN RPAREN | RETURN;
paramAssign: (( variableName ASSIGN)? expression)
    | refAssign
    | ( NOT? variableName MOVE_OUT variable);
selectionStmt : ifStmt | caseStmt;
ifStmt:
    IF expression THEN stmtList (ELSIF expression THEN stmtList)* (
        ELSE stmtList
    )? END_IF;
caseStmt        : CASE expression OF caseSelection+ ( ELSE stmtList)? END_CASE;
caseSelection   : caseList COLON stmtList;
caseList        : caseListElem ( COMMA caseListElem)*;
caseListElem    : subrange | constantExpr;
iterationStmt   : forStmt | whileStmt | repeatStmt | EXIT | CONTINUE;
forStmt         : FOR controlVariable ASSIGN forList DO stmtList END_FOR;
controlVariable : identifier;
forList         : expression TO expression ( BY expression)?;
whileStmt       : WHILE expression DO stmtList END_WHILE;
repeatStmt      : REPEAT stmtList UNTIL expression END_REPEAT;

// table 62 - Configuration and resource declaration
configName       : identifier;
resourceTypeName : identifier;
configDecl:
    CONFIGURATION configName globalVarDecls? (
        singleResourceDecl
        | resourceDecl+
    ) accessDecls? configInit? END_CONFIGURATION;
resourceDecl:
    RESOURCE resourceName ON resourceTypeName globalVarDecls? singleResourceDecl END_RESOURCE;
singleResourceDecl : (taskConfig SCOLON)* ( progConfig SCOLON)+;
resourceName       : identifier;
accessDecls        : VAR_ACCESS ( accessDecl SCOLON)* END_VAR;
accessDecl         : accessName COLON accessPath COLON dataTypeAccess accessDirection?;
accessPath: (resourceName DOT)? directVariable
    | (resourceName DOT)? (progName DOT)? (
        (fBInstanceName | classInstanceName) DOT
    )* symbolicVariable;
globalVarAccess  : (resourceName DOT)? globalVarName ( DOT structElemName)?;
accessName       : identifier;
progOutputAccess : progName DOT symbolicVariable;
progName         : identifier;
accessDirection  : READ_WRITE | READ_ONLY;
taskConfig       : TASK taskName taskInit;
taskName         : identifier;
taskInit:
    LPAREN (SINGLE ASSIGN dataSource COMMA)? (INTERVAL ASSIGN dataSource COMMA)? PRIORITY ASSIGN unsignedInt RPAREN;
dataSource : constant | globalVarAccess | progOutputAccess | directVariable;
progConfig:
    PROGRAM (RETAIN | NON_RETAIN)? progName (WITH taskName)? COLON progTypeAccess (
        LPAREN progConfElems RPAREN
    )?;
progConfElems : progConfElem ( COMMA progConfElem)*;
progConfElem  : fBTask | progCnxn;
fBTask        : fBInstanceName WITH taskName;
progCnxn:
    symbolicVariable ASSIGN progDataSource
    | symbolicVariable MOVE_OUT dataSink;
progDataSource : constant | enumValue | globalVarAccess | directVariable;
dataSink       : globalVarAccess | directVariable;
configInit     : VAR_CONFIG (configInstInit SCOLON)* END_VAR;
configInstInit:
    resourceName DOT progName DOT ((fBInstanceName | classInstanceName) DOT)* (
        variableName locatedAt? COLON locVarSpecInit
        | (
            (fBInstanceName COLON fBTypeAccess)
            | ( classInstanceName COLON classTypeAccess)
        ) ASSIGN structInit
    );

// table 64 - namespace
namespaceDecl:
    NAMESPACE INTERNAL? namespaceHName usingDirective* namespaceElements END_NAMESPACE;
namespaceElements: (
        dataTypeDecl
        | funcDecl
        | fBDecl
        | classDecl
        | interfaceDecl
        | namespaceDecl
    )+;
namespaceHName : namespaceName ( DOT namespaceName)*;
namespaceName  : identifier;
usingDirective : USING namespaceHName (COMMA namespaceHName)* SCOLON;
pouDecl:
    usingDirective* (
        globalVarDecls
        | dataTypeDecl
        | accessDecls
        | funcDecl
        | fBDecl
        | classDecl
        | interfaceDecl
        | namespaceDecl
    )+;

// table 48 - Class table 50 textual call of methods – formal and non-formal parameter list
classDecl:
    CLASS (FINAL | ABSTRACT)? classTypeName usingDirective* (
        EXTENDS classTypeAccess
    )? (IMPLEMENTS interfaceNameList)? (funcVarDecls | otherVarDecls)* (
        methodDecl
    )* END_CLASS;
classTypeName     : identifier;
classTypeAccess   : (namespaceName DOT)* classTypeName;
className         : identifier;
classInstanceName : (namespaceName DOT)* className DEREF*;
interfaceDecl:
    INTERFACE interfaceTypeName usingDirective* (EXTENDS interfaceNameList)? methodPrototype* END_INTERFACE;
methodPrototype:
    METHOD methodName (COLON dataTypeAccess)? ioVarDecls* END_METHOD;
interfaceSpecInit   : variableList (ASSIGN interfaceValue)?;
interfaceValue      : symbolicVariable | fBInstanceName | classInstanceName | NULL;
interfaceNameList   : interfaceTypeAccess (COMMA interfaceTypeAccess)*;
interfaceTypeName   : identifier;
interfaceTypeAccess : (namespaceName DOT)* interfaceTypeName;
interfaceName       : identifier;
accessSpec          : PUBLIC | PROTECTED | PRIVATE | INTERNAL;

// table 47 - program declaration
progDecl:
    PROGRAM progTypeName (
        ioVarDecls
        | funcVarDecls
        | tempVarDecls
        | otherVarDecls
        | locVarDecls
        | progAccessDecls
    )* fBBody END_PROGRAM;
progTypeName    : identifier;
progTypeAccess  : ( namespaceName DOT)* progTypeName;
progAccessDecls : VAR_ACCESS (progAccessDecl SCOLON)* END_VAR;
progAccessDecl:
    accessName COLON symbolicVariable multibitPartAccess? COLON dataTypeAccess accessDirection?;

// table 40 – function block type declaration table 41 - function block instance declaration
fBTypeName    : derivedFBName;
fBTypeAccess  : ( namespaceName DOT)* fBTypeName;
derivedFBName : identifier;
fBDecl:
    FUNCTION_BLOCK (FINAL | ABSTRACT)? derivedFBName usingDirective* (
        EXTENDS (fBTypeAccess | classTypeAccess)
    )? (IMPLEMENTS interfaceNameList)? (
        fBIOVarDecls
        | funcVarDecls
        | tempVarDecls
        | otherVarDecls
    )* (methodDecl)* fBBody? END_FUNCTION_BLOCK;
fBIOVarDecls : fBInputDecls | fBOutputDecls | inOutDecls;

// Non-standard: CONSTANT
fBInputDecls : VAR_INPUT (CONSTANT | RETAIN | NON_RETAIN)? ( fBInputDecl SCOLON)* END_VAR;
fBInputDecl  : varDeclInit | edgeDecl | arrayConformDecl;
fBOutputDecls:
    VAR_OUTPUT (RETAIN | NON_RETAIN)? (fBOutputDecl SCOLON)* END_VAR;
fBOutputDecl      : varDeclInit | arrayConformDecl;
otherVarDecls     : retainVarDecls | nonRetainVarDecls | locPartlyVarDecl;
nonRetainVarDecls : VAR NON_RETAIN accessSpec? (varDeclInit SCOLON)* END_VAR;
fBBody            : stmtList;
methodDecl:
    METHOD accessSpec (FINAL | ABSTRACT)? OVERRIDE? methodName (
        COLON dataTypeAccess
    )? (ioVarDecls | funcVarDecls | tempVarDecls)* funcBody END_METHOD;
methodName : identifier;

// Table 19 - Function declaration
funcName        : derivedFuncName | stdFunctionName;
stdFunctionName : MOD | OR | XOR | AND;
funcAccess      : ( namespaceName DOT)* funcName;
derivedFuncName : identifier;
funcDecl:
    FUNCTION derivedFuncName (COLON dataTypeAccess)? usingDirective* (
        ioVarDecls
        | funcVarDecls
        | tempVarDecls
    )* funcBody END_FUNCTION;
ioVarDecls   : inputDecls | outputDecls | inOutDecls;
funcVarDecls : externalVarDecls | varDecls;
funcBody     : stmtList;

// Table 13 - Declaration of variables
// Table 14 – Initialization of variables
variable : directVariable | symbolicVariable;
symbolicVariable: (( THIS DOT) | ( namespaceName DOT)+)? (
        varAccess
        | multiElemVar 
    );
varAccess        : variableName | refDeref;
variableName     : identifier;
multiElemVar     : varAccess (subscriptList | structVariable)+;
subscriptList    : LBRACK subscript ( COMMA subscript)* RBRACK;
subscript        : expression;
structVariable   : DOT structElemSelect;
structElemSelect : varAccess;
inputDecls       : VAR_INPUT (RETAIN | NON_RETAIN)? (inputDecl SCOLON)* END_VAR;
inputDecl        : varDeclInit | edgeDecl | arrayConformDecl;
edgeDecl         : variableList COLON BOOL ( R_EDGE | F_EDGE);
varDeclInit:
    variableList COLON (simpleSpecInit | strVarDecl | refSpecInit | pointerSpecInit)
    | arrayVarDeclInit
    | structVarDeclInit
    | fBDeclInit
    | interfaceSpecInit;
refVarDecl       : variableList COLON refSpec;
interfaceVarDecl : variableList COLON interfaceTypeAccess;
variableList     : variableName ( COMMA variableName)*;
arrayVarDeclInit : variableList COLON arraySpecInit;
arrayConformand:
    ARRAY LBRACK MUL_SIGN (COMMA MUL_SIGN)* RBRACK OF dataTypeAccess;
arrayConformDecl  : variableList COLON arrayConformand;
structVarDeclInit : variableList COLON structSpecInit;
fBDeclNoInit      : fBName (COMMA fBName)* COLON fBTypeAccess;
fBDeclInit        : fBDeclNoInit ( ASSIGN structInit)?;
fBName            : identifier;
fBInstanceName    : ( namespaceName DOT)* fBName DEREF*;
outputDecls       : VAR_OUTPUT (RETAIN | NON_RETAIN)? ( outputDecl SCOLON)* END_VAR;
outputDecl        : varDeclInit | arrayConformDecl;
inOutDecls        : VAR_IN_OUT ( inOutVarDecl SCOLON)* END_VAR;
inOutVarDecl      : varDecl | arrayConformDecl | fBDeclNoInit;
varDecl:
    variableList COLON (simpleSpec | strVarDecl | arrayVarDecl | structVarDecl);
arrayVarDecl   : variableList COLON arraySpec;
structVarDecl  : variableList COLON structTypeAccess;
varDecls       : VAR CONSTANT? accessSpec? (varDeclInit SCOLON)* END_VAR;
retainVarDecls : VAR RETAIN accessSpec? (varDeclInit SCOLON)* END_VAR;
locVarDecls:
    VAR (CONSTANT | RETAIN | NON_RETAIN)? (locVarDecl SCOLON)* END_VAR;
locVarDecl : variableName? locatedAt COLON locVarSpecInit;
tempVarDecls:
    VAR_TEMP ((varDecl | refVarDecl | interfaceVarDecl) SCOLON)* END_VAR;
externalVarDecls : VAR_EXTERNAL CONSTANT? (externalDecl SCOLON)* END_VAR;
externalDecl:
    globalVarName COLON (
        simpleSpec
        | arraySpec
        | structTypeAccess
        | fBTypeAccess
        | refTypeAccess
    );
globalVarName : identifier;
globalVarDecls:
    VAR_GLOBAL (CONSTANT | RETAIN)? (globalVarDecl SCOLON)* END_VAR;
globalVarDecl : globalVarSpec COLON ( locVarSpecInit | fBTypeAccess);
globalVarSpec: (globalVarName ( COMMA globalVarName)*)
    | ( globalVarName locatedAt);
locVarSpecInit:
    simpleSpecInit
    | arraySpecInit
    | structSpecInit
    | sByteStrSpec
    | dByteStrSpec;
locatedAt        : AT directVariable;
strVarDecl       : sByteStrVarDecl | dByteStrVarDecl;
sByteStrVarDecl  : variableList COLON sByteStrSpec;
sByteStrSpec     : STRING stringSizeSpec? ( ASSIGN sByteCharStr)?;
dByteStrVarDecl  : variableList COLON dByteStrSpec;
dByteStrSpec     : WSTRING stringSizeSpec? ( ASSIGN dByteCharStr)?;
locPartlyVarDecl : VAR (RETAIN | NON_RETAIN)? locPartlyVar* END_VAR;
locPartlyVar:
    variableName AT PERCENT localAtDirection MUL_SIGN COLON varSpec SCOLON;
varSpec:
    simpleSpec
    | arraySpec
    | structTypeAccess
    | (STRING | WSTRING) stringSizeSpec?;
stringSizeSpec: stdStringSizeSpec | extStringSizeSpec;
stdStringSizeSpec : LBRACK unsignedInt RBRACK;
extStringSizeSpec : LPAREN constantExpr RPAREN;
// Table 16 - Directly represented variables
directVariable : PERCENT localAtDirection unsignedInt (DOT unsignedInt)*;

// TODO : check for (I | Q | M) (X | B | W | D | L)? for directVariable TODO : check for (I | Q | M) for locPartlyVar
localAtDirection : identifier;

// TODO : check for ( X | B | W | D | L)
localAtType : identifier;

// Table 12 - Reference operations
refTypeDecl   : refTypeName COLON refSpecInit;
refSpecInit   : refSpec ( ASSIGN refValue)?;
refSpec       : REF_TO+ dataTypeAccess;
refTypeName   : identifier;
refTypeAccess : ( namespaceName DOT)* refTypeName;
refName       : identifier;
refValue      : refAddr | NULL;
refAddr:
    REF LPAREN (symbolicVariable | fBInstanceName | classInstanceName) RPAREN;
refAssign : refName ASSIGN (refName | refDeref | refValue);
refDeref  : refName DEREF+;

// Table 11 Declaration of user-defined data types and initialization
derivedTypeAccess:
    singleElemTypeAccess
    | arrayTypeAccess
    | structTypeAccess
    | stringTypeAccess
    | classTypeAccess
    | refTypeAccess
    | interfaceTypeAccess;
stringTypeAccess     : (namespaceName DOT)* stringTypeName;
singleElemTypeAccess : simpleTypeAccess | subrangeTypeAccess | enumTypeAccess;
simpleTypeAccess     : (namespaceName DOT)* simpleTypeName;
subrangeTypeAccess   : (namespaceName DOT)* subrangeTypeName;
enumTypeAccess       : (namespaceName DOT)* enumTypeName;
structTypeAccess     : (namespaceName DOT)* structTypeName;
arrayTypeAccess      : (namespaceName DOT)* arrayTypeName;

simpleTypeName   : identifier;
subrangeTypeName : identifier;
enumTypeName     : identifier;
structTypeName   : identifier;
arrayTypeName    : identifier;

dataTypeDecl : TYPE (typeDecl SCOLON)+ ENDTYPE;
typeDecl:
    simpleTypeDecl
    | subrangeTypeDecl
    | enumTypeDecl
    | arrayTypeDecl
    | structTypeDecl
    | strTypeDecl
    | refTypeDecl;
simpleTypeDecl   : simpleTypeName COLON simpleSpecInit;
simpleSpecInit   : simpleSpec ( ASSIGN constantExpr)?;
simpleSpec       : elemTypeName | simpleTypeAccess;
subrangeTypeDecl : subrangeTypeName COLON subrangeSpecInit;
subrangeSpecInit : subrangeSpec ( ASSIGN signedInt)?;
subrangeSpec     : intTypeName LPAREN subrange RPAREN | subrangeTypeAccess;
subrange         : constantExpr RANGE constantExpr;
enumTypeDecl:
    enumTypeName COLON (( elemTypeName? namedSpecInit) | enumSpecInit);
namedSpecInit:
    LPAREN enumValueSpec (COMMA enumValueSpec)* RPAREN (ASSIGN enumValue)?;
enumSpecInit: ((LPAREN identifier ( COMMA identifier)* RPAREN) | enumTypeAccess) (
        ASSIGN enumValue
    )?;
enumValueSpec : identifier (ASSIGN ( intLiteral | constantExpr))?;
enumValue     : ( enumTypeName SHARP)? identifier;
arrayTypeDecl : arrayTypeName COLON arraySpecInit;
arraySpecInit : arraySpec ( ASSIGN arrayInit)?;
arraySpec:
    arrayTypeAccess
    | ARRAY LBRACK subrange (COMMA subrange)* RBRACK OF dataTypeAccess;
arrayInit : LBRACK arrayElemInit (COMMA arrayElemInit)* RBRACK;
arrayElemInit:
    arrayElemInitValue
    | unsignedInt LPAREN arrayElemInitValue? RPAREN;
arrayElemInitValue : constantExpr | enumValue | structInit | arrayInit;
structTypeDecl     : structTypeName COLON structSpec;
structSpec         : structDecl | structSpecInit;
structSpecInit     : structTypeAccess (ASSIGN structInit)?;
structDecl         : STRUCT OVERLAP? (structElemDecl SCOLON)+ ENDSTRUCT;
structElemDecl:
    structElemName (locatedAt multibitPartAccess?)? COLON (
        simpleSpecInit
        | subrangeSpecInit
        | enumSpecInit
        | arraySpecInit
        | structSpecInit
    );
structElemName : identifier;
structInit     : LPAREN structElemInit (COMMA structElemInit)* RPAREN;
structElemInit:
    structElemName ASSIGN (
        constantExpr
        | enumValue
        | arrayInit
        | structInit
        | refValue
    );
strTypeDecl : stringTypeName COLON stringTypeName ( ASSIGN charLiteral)?;

// Table 10 Elementary data types 
dataTypeAccess : elemTypeName | derivedTypeAccess;
elemTypeName:
    numericTypeName
    | bitStrTypeName
    | stringTypeName
    | dateTypeName
    | timeTypeName;
numericTypeName : intTypeName | realTypeName;
intTypeName     : signedIntTypeName | unsignedIntTypeName;

signedIntTypeName   : SINT | INT | DINT | LINT;
unsignedIntTypeName : USINT | UINT | UDINT | ULINT;
realTypeName        : REAL | LREAL;
stringTypeName:
    STRING stringSizeSpec?
    | WSTRING stringSizeSpec?
    | CHAR
    | WCHAR;

timeTypeName     : TIME | LTIME | LT;
dateTypeName     : DATE | LDATE;
todTypeName      : TIME_OF_DAY | TOD | LTOD;
dtTypeName       : DATE_AND_TIME | DT | LDT;
bitStrTypeName   : boolTypeName | multibitTypeName;
boolTypeName     : BOOL;
multibitTypeName : BYTE | WORD | DWORD | LWORD;

//constants rules numeric literal
testConstant : constant+;
constant:
    numericLiteral
    | charLiteral
    | timeLiteral
    | bitStrLiteral
    | boolLiteral;
numericLiteral : intLiteral | realLiteral;
intLiteral     : (intTypeName SHARP)? ( signedInt | binaryInt | octalInt | hexInt);
// TODO: 0 or 1 allowed
boolLiteral : (boolTypeName SHARP)? ( UNSIGNED_INT | FALSE | TRUE);
realLiteral : (realTypeName SHARP)? (REAL_NUM);
bitStrLiteral: (multibitTypeName SHARP)? (
        unsignedInt
        | binaryInt
        | octalInt
        | hexInt
    );

// Table 8 - Duration literals Table 9 – Date and time of day literals
timeLiteral : duration | timeOfDay | date | dateAndTime;
// TODO: check identifier == T | LT
duration    : (timeTypeName | identifier ) SHARP (PLUS | MINUS)? interval;
fixPoint    : unsignedInt ( DOT unsignedInt)?;
interval:
    days
    | hours
    | minutes
    | seconds
    | milliseconds
    | microseconds
    | nanoseconds;
// days : (fixPoint 'd') | (unsignedInt 'd' '_'?)? hours?; hours : (fixPoint 'h') | (unsignedInt 'h' '_'?)? minutes?;
// minutes : (fixPoint 'm') | (unsignedInt 'm' '_'?)? seconds?; seconds : (fixPoint 's') | (unsignedInt 's' '_'?)?
// milliseconds?; milliseconds : (fixPoint 'ms') | (unsignedInt 'ms' '_'?)? microseconds?; microseconds : (fixPoint
// 'us') | (unsignedInt 'us' '_'?)? nanoseconds?; nanoseconds : fixPoint 'ns';

days         : fixPoint identifier hours?;
hours        : fixPoint identifier minutes?;
minutes      : fixPoint identifier seconds?;
seconds      : fixPoint identifier milliseconds?;
milliseconds : fixPoint identifier microseconds?;
microseconds : fixPoint identifier nanoseconds?;
nanoseconds  : fixPoint identifier;

timeOfDay   : (todTypeName | LTIME_OF_DAY) SHARP daytime;
daytime     : dayHour COLON dayMinute COLON daySecond;
dayHour     : unsignedInt;
dayMinute   : unsignedInt;
daySecond   : fixPoint;

// TODO: check identifier == D | LD
date        : ( dateTypeName | identifier) SHARP dateLiteral;
dateLiteral : year MINUS month MINUS day;
year        : unsignedInt;
month       : unsignedInt;
day         : unsignedInt;
dateAndTime : (dtTypeName | LDATE_AND_TIME) SHARP dateLiteral MINUS daytime;

//charachter string literal Table 6 - Character String literals Table 7 - Two-character combinations in character
// strings
charLiteral  : ( STRING | WSTRING SHARP)? charStr;
charStr      : sByteCharStr | dByteCharStr;
sByteCharStr : STRING_CONST;
dByteCharStr : WSTRING_CONST;

// S_Byte_Char_Str : '\'' S_Byte_Char_Value + '\''; D_Byte_Char_Str : '"' D_Byte_Char_Value + '"'; S_Byte_Char_Value :
// Common_Char_Value | '$\'' | '"' | '$' Hex_Digit Hex_Digit; D_Byte_Char_Value : Common_Char_Value | '\'' | '$"' | '$'
// Hex_Digit Hex_Digit Hex_Digit Hex_Digit; Common_Char_Value : ' ' | '!' | SHARP | PERCENT | AMP | LPAREN..'/' |
// '0RANGE9' | COLON..'@' | 'ARANGEZ' | LBRACK..'`' | 'aRANGEz' | '{RANGE~' | '$$' | '$L' | '$N' | '$P' | '$R' | '$T';
// any printable characters except $, " and '

sign        : PLUS | MINUS;
unsignedInt : UNSIGNED_INT;
signedInt   : sign? UNSIGNED_INT;
binaryInt   : BIN_INT;
octalInt    : OCT_INT;
hexInt      : HEX_INT;
identifier  : IDENTIFIER;

// CodeSys syntax non-standard extensions
pointerSpec: POINTER TO varSpec;
pointerVarDecl: variableList COLON pointerSpec;
pointerSpecInit   : pointerSpec ( ASSIGN refValue)?;
pointerAddr:
    REF LPAREN (symbolicVariable | fBInstanceName | classInstanceName) RPAREN;
pointerValue      : pointerAddr | NULL;