# Interpreter

## Description
The pattern defines a representation for a grammar of a language and a mechanism to interpret (evaluate) sentences in that language. It's suitable for problems where similar expressions occur frequently (e.g., mathematical formulas, logical conditions, queries) and can be represented as an abstract syntax tree.

## Participants
- **AbstractExpression** - an interface with an `Interpret(Context)` method. Declares an abstract Interpret operation that is common to all nodes in the abstract syntax tree.
- **TerminalExpression** - implements the operation for terminal symbols in the grammar (e.g., a number).
- **NonterminalExpression** - implements the operation for non-terminal symbols (e.g., +, -, * operations). Represents rules in the grammar.
- **Context** - stores global information needed for interpretation (e.g., variable values). Contains information that’s global to the interpreter.
- **Client** - Builds (or is provided with) the abstract syntax tree. It invokes the Interpret operation.

## When to use
- The grammar is simple and stable.
- You frequently need to evaluate expressions that can be conveniently represented as a tree.
- It's easy to define classes for each grammar rule.
