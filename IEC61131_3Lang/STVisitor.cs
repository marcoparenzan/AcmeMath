using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Linq.Expressions;

namespace IEC61131ST
{
    // https://github.com/0xDAD/plcc-g4
    public partial class STVisitor<TTarget> : ISTParserVisitor<Expression>
    {
        TTarget contextInstance;
        ParameterExpression contextExpression;

        public STVisitor(TTarget instance)
        {
            this.contextInstance = instance;
            this.contextExpression = Expression.Variable(typeof(TTarget), "context");
        }

        public Expression Visit(IParseTree tree)
        {
            if (tree.Payload is STParser.AccessDeclContext ad)
            {
                return VisitAccessDecl(ad);
            }
            else
            {
                throw new NotImplementedException("");
            }
        }

        public Expression VisitAccessDecl([NotNull] STParser.AccessDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAccessDecls([NotNull] STParser.AccessDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAccessDirection([NotNull] STParser.AccessDirectionContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAccessName([NotNull] STParser.AccessNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAccessPath([NotNull] STParser.AccessPathContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAccessSpec([NotNull] STParser.AccessSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAddExpr([NotNull] STParser.AddExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAndExpr([NotNull] STParser.AndExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayConformand([NotNull] STParser.ArrayConformandContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayConformDecl([NotNull] STParser.ArrayConformDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayElemInit([NotNull] STParser.ArrayElemInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayElemInitValue([NotNull] STParser.ArrayElemInitValueContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayInit([NotNull] STParser.ArrayInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArraySpec([NotNull] STParser.ArraySpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArraySpecInit([NotNull] STParser.ArraySpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayTypeAccess([NotNull] STParser.ArrayTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayTypeDecl([NotNull] STParser.ArrayTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayTypeName([NotNull] STParser.ArrayTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayVarDecl([NotNull] STParser.ArrayVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitArrayVarDeclInit([NotNull] STParser.ArrayVarDeclInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAssignmentAttempt([NotNull] STParser.AssignmentAttemptContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitAssignStmt([NotNull] STParser.AssignStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitBinaryInt([NotNull] STParser.BinaryIntContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitBitStrLiteral([NotNull] STParser.BitStrLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitBitStrTypeName([NotNull] STParser.BitStrTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitBoolLiteral([NotNull] STParser.BoolLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitBoolTypeName([NotNull] STParser.BoolTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCaseList([NotNull] STParser.CaseListContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCaseListElem([NotNull] STParser.CaseListElemContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCaseSelection([NotNull] STParser.CaseSelectionContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCaseStmt([NotNull] STParser.CaseStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCharLiteral([NotNull] STParser.CharLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCharStr([NotNull] STParser.CharStrContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitChildren(IRuleNode node)
        {
            throw new NotImplementedException();
        }

        public Expression VisitClassDecl([NotNull] STParser.ClassDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitClassInstanceName([NotNull] STParser.ClassInstanceNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitClassName([NotNull] STParser.ClassNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitClassTypeAccess([NotNull] STParser.ClassTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitClassTypeName([NotNull] STParser.ClassTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitCompareExpr([NotNull] STParser.CompareExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitConfigDecl([NotNull] STParser.ConfigDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitConfigInit([NotNull] STParser.ConfigInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitConfigInstInit([NotNull] STParser.ConfigInstInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitConfigName([NotNull] STParser.ConfigNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitConstant([NotNull] STParser.ConstantContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitConstantExpr([NotNull] STParser.ConstantExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitControlVariable([NotNull] STParser.ControlVariableContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDataSink([NotNull] STParser.DataSinkContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDataSource([NotNull] STParser.DataSourceContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDataTypeAccess([NotNull] STParser.DataTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDataTypeDecl([NotNull] STParser.DataTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDate([NotNull] STParser.DateContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDateAndTime([NotNull] STParser.DateAndTimeContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDateLiteral([NotNull] STParser.DateLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDateTypeName([NotNull] STParser.DateTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDay([NotNull] STParser.DayContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDayHour([NotNull] STParser.DayHourContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDayMinute([NotNull] STParser.DayMinuteContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDays([NotNull] STParser.DaysContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDaySecond([NotNull] STParser.DaySecondContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDaytime([NotNull] STParser.DaytimeContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDByteCharStr([NotNull] STParser.DByteCharStrContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDByteStrSpec([NotNull] STParser.DByteStrSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDByteStrVarDecl([NotNull] STParser.DByteStrVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDerivedFBName([NotNull] STParser.DerivedFBNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDerivedFuncName([NotNull] STParser.DerivedFuncNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDerivedTypeAccess([NotNull] STParser.DerivedTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDirectVariable([NotNull] STParser.DirectVariableContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDtTypeName([NotNull] STParser.DtTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitDuration([NotNull] STParser.DurationContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEdgeDecl([NotNull] STParser.EdgeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitElemTypeName([NotNull] STParser.ElemTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEnumSpecInit([NotNull] STParser.EnumSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEnumTypeAccess([NotNull] STParser.EnumTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEnumTypeDecl([NotNull] STParser.EnumTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEnumTypeName([NotNull] STParser.EnumTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEnumValue([NotNull] STParser.EnumValueContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEnumValueSpec([NotNull] STParser.EnumValueSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitEquExpr([NotNull] STParser.EquExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException();
        }

        public Expression VisitExpression([NotNull] STParser.ExpressionContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitExternalDecl([NotNull] STParser.ExternalDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitExternalVarDecls([NotNull] STParser.ExternalVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitExtStringSizeSpec([NotNull] STParser.ExtStringSizeSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBBody([NotNull] STParser.FBBodyContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBDecl([NotNull] STParser.FBDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBDeclInit([NotNull] STParser.FBDeclInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBDeclNoInit([NotNull] STParser.FBDeclNoInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBInputDecl([NotNull] STParser.FBInputDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBInputDecls([NotNull] STParser.FBInputDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBInstanceName([NotNull] STParser.FBInstanceNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBIOVarDecls([NotNull] STParser.FBIOVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBName([NotNull] STParser.FBNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBOutputDecl([NotNull] STParser.FBOutputDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBOutputDecls([NotNull] STParser.FBOutputDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBTask([NotNull] STParser.FBTaskContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBTypeAccess([NotNull] STParser.FBTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFBTypeName([NotNull] STParser.FBTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFixPoint([NotNull] STParser.FixPointContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitForList([NotNull] STParser.ForListContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitForStmt([NotNull] STParser.ForStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFuncAccess([NotNull] STParser.FuncAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFuncBody([NotNull] STParser.FuncBodyContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFuncCall([NotNull] STParser.FuncCallContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFuncDecl([NotNull] STParser.FuncDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFuncName([NotNull] STParser.FuncNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitFuncVarDecls([NotNull] STParser.FuncVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitGlobalVarAccess([NotNull] STParser.GlobalVarAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitGlobalVarDecl([NotNull] STParser.GlobalVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitGlobalVarDecls([NotNull] STParser.GlobalVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitGlobalVarName([NotNull] STParser.GlobalVarNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitGlobalVarSpec([NotNull] STParser.GlobalVarSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitHexInt([NotNull] STParser.HexIntContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitHours([NotNull] STParser.HoursContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitIdentifier([NotNull] STParser.IdentifierContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitIfStmt([NotNull] STParser.IfStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInOutDecls([NotNull] STParser.InOutDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInOutVarDecl([NotNull] STParser.InOutVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInputDecl([NotNull] STParser.InputDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInputDecls([NotNull] STParser.InputDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceDecl([NotNull] STParser.InterfaceDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceName([NotNull] STParser.InterfaceNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceNameList([NotNull] STParser.InterfaceNameListContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceSpecInit([NotNull] STParser.InterfaceSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceTypeAccess([NotNull] STParser.InterfaceTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceTypeName([NotNull] STParser.InterfaceTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceValue([NotNull] STParser.InterfaceValueContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterfaceVarDecl([NotNull] STParser.InterfaceVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInterval([NotNull] STParser.IntervalContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitIntLiteral([NotNull] STParser.IntLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitIntTypeName([NotNull] STParser.IntTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitInvocation([NotNull] STParser.InvocationContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitIoVarDecls([NotNull] STParser.IoVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitIterationStmt([NotNull] STParser.IterationStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocalAtDirection([NotNull] STParser.LocalAtDirectionContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocalAtType([NotNull] STParser.LocalAtTypeContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocatedAt([NotNull] STParser.LocatedAtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocPartlyVar([NotNull] STParser.LocPartlyVarContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocPartlyVarDecl([NotNull] STParser.LocPartlyVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocVarDecl([NotNull] STParser.LocVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocVarDecls([NotNull] STParser.LocVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitLocVarSpecInit([NotNull] STParser.LocVarSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMethodDecl([NotNull] STParser.MethodDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMethodName([NotNull] STParser.MethodNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMethodPrototype([NotNull] STParser.MethodPrototypeContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMicroseconds([NotNull] STParser.MicrosecondsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMilliseconds([NotNull] STParser.MillisecondsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMinutes([NotNull] STParser.MinutesContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMonth([NotNull] STParser.MonthContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMultibitPartAccess([NotNull] STParser.MultibitPartAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMultibitTypeName([NotNull] STParser.MultibitTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitMultiElemVar([NotNull] STParser.MultiElemVarContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNamedSpecInit([NotNull] STParser.NamedSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNamespaceDecl([NotNull] STParser.NamespaceDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNamespaceElements([NotNull] STParser.NamespaceElementsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNamespaceHName([NotNull] STParser.NamespaceHNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNamespaceName([NotNull] STParser.NamespaceNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNanoseconds([NotNull] STParser.NanosecondsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNonRetainVarDecls([NotNull] STParser.NonRetainVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNumericLiteral([NotNull] STParser.NumericLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitNumericTypeName([NotNull] STParser.NumericTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitOctalInt([NotNull] STParser.OctalIntContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitOtherVarDecls([NotNull] STParser.OtherVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitOutputDecl([NotNull] STParser.OutputDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitOutputDecls([NotNull] STParser.OutputDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitParamAssign([NotNull] STParser.ParamAssignContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPointerAddr([NotNull] STParser.PointerAddrContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPointerSpec([NotNull] STParser.PointerSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPointerSpecInit([NotNull] STParser.PointerSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPointerValue([NotNull] STParser.PointerValueContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPointerVarDecl([NotNull] STParser.PointerVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPouDecl([NotNull] STParser.PouDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPowerExpr([NotNull] STParser.PowerExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitPrimaryExpr([NotNull] STParser.PrimaryExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgAccessDecl([NotNull] STParser.ProgAccessDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgAccessDecls([NotNull] STParser.ProgAccessDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgCnxn([NotNull] STParser.ProgCnxnContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgConfElem([NotNull] STParser.ProgConfElemContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgConfElems([NotNull] STParser.ProgConfElemsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgConfig([NotNull] STParser.ProgConfigContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgDataSource([NotNull] STParser.ProgDataSourceContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgDecl([NotNull] STParser.ProgDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgName([NotNull] STParser.ProgNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgOutputAccess([NotNull] STParser.ProgOutputAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgTypeAccess([NotNull] STParser.ProgTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitProgTypeName([NotNull] STParser.ProgTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRealLiteral([NotNull] STParser.RealLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRealTypeName([NotNull] STParser.RealTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefAddr([NotNull] STParser.RefAddrContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefAssign([NotNull] STParser.RefAssignContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefDeref([NotNull] STParser.RefDerefContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefName([NotNull] STParser.RefNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefSpec([NotNull] STParser.RefSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefSpecInit([NotNull] STParser.RefSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefTypeAccess([NotNull] STParser.RefTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefTypeDecl([NotNull] STParser.RefTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefTypeName([NotNull] STParser.RefTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefValue([NotNull] STParser.RefValueContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRefVarDecl([NotNull] STParser.RefVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRepeatStmt([NotNull] STParser.RepeatStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitResourceDecl([NotNull] STParser.ResourceDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitResourceName([NotNull] STParser.ResourceNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitResourceTypeName([NotNull] STParser.ResourceTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitRetainVarDecls([NotNull] STParser.RetainVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSByteCharStr([NotNull] STParser.SByteCharStrContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSByteStrSpec([NotNull] STParser.SByteStrSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSByteStrVarDecl([NotNull] STParser.SByteStrVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSeconds([NotNull] STParser.SecondsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSelectionStmt([NotNull] STParser.SelectionStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSign([NotNull] STParser.SignContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSignedInt([NotNull] STParser.SignedIntContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSignedIntTypeName([NotNull] STParser.SignedIntTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSimpleSpec([NotNull] STParser.SimpleSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSimpleSpecInit([NotNull] STParser.SimpleSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSimpleTypeAccess([NotNull] STParser.SimpleTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSimpleTypeDecl([NotNull] STParser.SimpleTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSimpleTypeName([NotNull] STParser.SimpleTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSingleElemTypeAccess([NotNull] STParser.SingleElemTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSingleResourceDecl([NotNull] STParser.SingleResourceDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStdFunctionName([NotNull] STParser.StdFunctionNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStdStringSizeSpec([NotNull] STParser.StdStringSizeSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStmt([NotNull] STParser.StmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStmtList([NotNull] STParser.StmtListContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStringSizeSpec([NotNull] STParser.StringSizeSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStringTypeAccess([NotNull] STParser.StringTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStringTypeName([NotNull] STParser.StringTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStrTypeDecl([NotNull] STParser.StrTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructDecl([NotNull] STParser.StructDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructElemDecl([NotNull] STParser.StructElemDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructElemInit([NotNull] STParser.StructElemInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructElemName([NotNull] STParser.StructElemNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructElemSelect([NotNull] STParser.StructElemSelectContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructInit([NotNull] STParser.StructInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructSpec([NotNull] STParser.StructSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructSpecInit([NotNull] STParser.StructSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructTypeAccess([NotNull] STParser.StructTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructTypeDecl([NotNull] STParser.StructTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructTypeName([NotNull] STParser.StructTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructVarDecl([NotNull] STParser.StructVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructVarDeclInit([NotNull] STParser.StructVarDeclInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStructVariable([NotNull] STParser.StructVariableContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitStrVarDecl([NotNull] STParser.StrVarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubprogCtrlStmt([NotNull] STParser.SubprogCtrlStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubrange([NotNull] STParser.SubrangeContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubrangeSpec([NotNull] STParser.SubrangeSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubrangeSpecInit([NotNull] STParser.SubrangeSpecInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubrangeTypeAccess([NotNull] STParser.SubrangeTypeAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubrangeTypeDecl([NotNull] STParser.SubrangeTypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubrangeTypeName([NotNull] STParser.SubrangeTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubscript([NotNull] STParser.SubscriptContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSubscriptList([NotNull] STParser.SubscriptListContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitSymbolicVariable([NotNull] STParser.SymbolicVariableContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTaskConfig([NotNull] STParser.TaskConfigContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTaskInit([NotNull] STParser.TaskInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTaskName([NotNull] STParser.TaskNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTempVarDecls([NotNull] STParser.TempVarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTerm([NotNull] STParser.TermContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTerminal(ITerminalNode node)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTestConstant([NotNull] STParser.TestConstantContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTimeLiteral([NotNull] STParser.TimeLiteralContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTimeOfDay([NotNull] STParser.TimeOfDayContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTimeTypeName([NotNull] STParser.TimeTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTodTypeName([NotNull] STParser.TodTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTranslationUnitDecl([NotNull] STParser.TranslationUnitDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitTypeDecl([NotNull] STParser.TypeDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitUnaryExpr([NotNull] STParser.UnaryExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitUnsignedInt([NotNull] STParser.UnsignedIntContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitUnsignedIntTypeName([NotNull] STParser.UnsignedIntTypeNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitUsingDirective([NotNull] STParser.UsingDirectiveContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVarAccess([NotNull] STParser.VarAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVarDecl([NotNull] STParser.VarDeclContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVarDeclInit([NotNull] STParser.VarDeclInitContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVarDecls([NotNull] STParser.VarDeclsContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVariable([NotNull] STParser.VariableContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVariableAccess([NotNull] STParser.VariableAccessContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVariableList([NotNull] STParser.VariableListContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVariableName([NotNull] STParser.VariableNameContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitVarSpec([NotNull] STParser.VarSpecContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitWhileStmt([NotNull] STParser.WhileStmtContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitXorExpr([NotNull] STParser.XorExprContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitYear([NotNull] STParser.YearContext context)
        {
            throw new NotImplementedException();
        }
    }
}