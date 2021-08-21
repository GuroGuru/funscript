grammar funscript;

script          : (block|statement)+;

block           : BLOCK LITERAL(COLON) (statement)* ;

statement       : sayStatement|COMMENT;

sayStatement    : (LITERAL)? TEXT;

HASH            : '#';

BLOCK           : 'block';

COLON           : ':';

SQ              : '\'';

DQ              : '"';

COMMENT         : (HASH).*?(EOF|[\t\r\n]);

TEXT            : (SQ|DQ).*?(SQ|DQ);

LITERAL         : ([a-zA-Z_0-9][a-zA-Z_0-9]*);

WS              : [ \t\r\n]+ -> skip;