﻿using System;
using System.Runtime.InteropServices;
using RDotNet.R.Adapter.Unix;
using RDotNet.R.Adapter.Windows;

namespace RDotNet.R.Adapter
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_setStartTime();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Rf_initialize_R(int ac, string[] argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void cmdlineoptions(int ac, string[] argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_set_command_line_arguments(int argc, string[] argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_DefParams_Unix(ref Common start);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_DefParams_Windows(ref RStartupParameter startupParameter);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_SetParams_Unix(ref Common start);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_SetParams_Windows(ref RStartupParameter startupParameter);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void setup_Rmainloop();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_ReplDLLinit();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Rf_initEmbeddedR(int argc, string[] argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_endEmbeddedR(int fatal);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_RunExitFinalizers();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_CleanEd();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_CleanTempDir();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_protect(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_PreserveObject(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_ReleaseObject(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_unprotect(int count);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_unprotect_ptr(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_install(string s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_mkString(string s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_mkChar(string s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_asCharacterFactor(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_allocVector(SymbolicExpressionType type, int length);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_coerceVector(IntPtr sexp, SymbolicExpressionType type);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isVector(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isFrame(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isS4(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isString(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isNull(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isPairList(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Rf_length(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_allocMatrix(SymbolicExpressionType type, int rowCount, int columnCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isMatrix(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Rf_nrows(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int Rf_ncols(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_allocList(int length);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isList(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_eval(IntPtr statement, IntPtr environment);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr R_tryEval(IntPtr statement, IntPtr environment, out bool errorOccurred);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_PrintValue(IntPtr value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr R_ParseVector(IntPtr statement, int statementCount, out ParseStatus status, IntPtr _);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_findVar(IntPtr name, IntPtr environment);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_setVar(IntPtr name, IntPtr value, IntPtr environment);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void Rf_defineVar(IntPtr name, IntPtr value, IntPtr environment);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_getAttrib(IntPtr sexp, IntPtr name);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_setAttrib(IntPtr sexp, IntPtr name, IntPtr value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr R_do_slot(IntPtr sexp, IntPtr name);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr R_do_slot_assign(IntPtr sexp, IntPtr name, IntPtr value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr R_getClassDef(string what);

    public delegate bool R_has_slot(IntPtr sexp, IntPtr name);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isEnvironment(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isExpression(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isSymbol(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isLanguage(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isFunction(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isFactor(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool Rf_isOrdered(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr R_lsInternal(IntPtr environment, bool all);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_applyClosure(IntPtr call, IntPtr value, IntPtr arguments, IntPtr environment, IntPtr suppliedEnvironment);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_VectorToPairList(IntPtr sexp);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_allocSExp(SymbolicExpressionType type);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_NewEnvironment(IntPtr names, IntPtr values, IntPtr parent);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_cons(IntPtr sexp, IntPtr next);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr Rf_lcons(IntPtr sexp, IntPtr next);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void R_gc();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr getValue();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr GetDllVersion();
}