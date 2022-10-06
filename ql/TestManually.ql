/**
 * @name Test
 * @kind problem
 * @problem.severity warning
 * @id csharp/example/Manually
 */

import csharp

from Method format, MethodCall call, Expr formatString
where
  format.hasQualifiedName("System.String.Format") and
  call.getTarget() = format and
  formatString = call.getArgument(0) and
  formatString.getType() instanceof StringType and
  not exists(StringLiteral source |
    DataFlow::localFlow(DataFlow::exprNode(source), DataFlow::exprNode(formatString))
  )
select call, "Argument to 'string.Format' isn't hard-coded."
