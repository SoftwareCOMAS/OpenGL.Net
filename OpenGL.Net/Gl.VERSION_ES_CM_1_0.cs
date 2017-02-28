
// Copyright (C) 2015-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_VERSION_ES_CL_1_0 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int VERSION_ES_CL_1_0 = 1;

		/// <summary>
		/// Value of GL_VERSION_ES_CM_1_1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int VERSION_ES_CM_1_1 = 1;

		/// <summary>
		/// Value of GL_VERSION_ES_CL_1_1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int VERSION_ES_CL_1_1 = 1;

		/// <summary>
		/// Binding for glClipPlanef.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClipPlane(Int32 p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanef != null, "pglClipPlanef not implemented");
					Delegates.pglClipPlanef(p, p_eqn);
					LogFunction("glClipPlanef({0}, {1})", LogEnumName(p), LogValue(eqn));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFrustumf.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Frustum(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglFrustumf != null, "pglFrustumf not implemented");
			Delegates.pglFrustumf(l, r, b, t, n, f);
			LogFunction("glFrustumf({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetClipPlanef.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetClipPlane(Int32 plane, [Out] float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanef != null, "pglGetClipPlanef not implemented");
					Delegates.pglGetClipPlanef(plane, p_equation);
					LogFunction("glGetClipPlanef({0}, {1})", LogEnumName(plane), LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glOrthof.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Ortho(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglOrthof != null, "pglOrthof not implemented");
			Delegates.pglOrthof(l, r, b, t, n, f);
			LogFunction("glOrthof({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glAlphaFuncx.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void AlphaFunc(Int32 func, IntPtr @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncx != null, "pglAlphaFuncx not implemented");
			Delegates.pglAlphaFuncx(func, @ref);
			LogFunction("glAlphaFuncx({0}, 0x{1})", LogEnumName(func), @ref.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearColorx.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClearColor(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearColorx != null, "pglClearColorx not implemented");
			Delegates.pglClearColorx(red, green, blue, alpha);
			LogFunction("glClearColorx(0x{0}, 0x{1}, 0x{2}, 0x{3})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"), alpha.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearDepthx.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClearDepth(IntPtr depth)
		{
			Debug.Assert(Delegates.pglClearDepthx != null, "pglClearDepthx not implemented");
			Delegates.pglClearDepthx(depth);
			LogFunction("glClearDepthx(0x{0})", depth.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClipPlanex.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClipPlane(Int32 plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanex != null, "pglClipPlanex not implemented");
					Delegates.pglClipPlanex(plane, p_equation);
					LogFunction("glClipPlanex({0}, {1})", LogEnumName(plane), LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColor4x.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Color4(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglColor4x != null, "pglColor4x not implemented");
			Delegates.pglColor4x(red, green, blue, alpha);
			LogFunction("glColor4x(0x{0}, 0x{1}, 0x{2}, 0x{3})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"), alpha.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDepthRangex.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void DepthRange(IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglDepthRangex != null, "pglDepthRangex not implemented");
			Delegates.pglDepthRangex(n, f);
			LogFunction("glDepthRangex(0x{0}, 0x{1})", n.ToString("X8"), f.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFogx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Fog(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglFogx != null, "pglFogx not implemented");
			Delegates.pglFogx(pname, param);
			LogFunction("glFogx({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFogxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Fog(Int32 pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglFogxv != null, "pglFogxv not implemented");
					Delegates.pglFogxv(pname, p_param);
					LogFunction("glFogxv({0}, {1})", LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFrustumx.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Frustum(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglFrustumx != null, "pglFrustumx not implemented");
			Delegates.pglFrustumx(l, r, b, t, n, f);
			LogFunction("glFrustumx(0x{0}, 0x{1}, 0x{2}, 0x{3}, 0x{4}, 0x{5})", l.ToString("X8"), r.ToString("X8"), b.ToString("X8"), t.ToString("X8"), n.ToString("X8"), f.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetClipPlanex.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetClipPlane(Int32 plane, [Out] IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanex != null, "pglGetClipPlanex not implemented");
					Delegates.pglGetClipPlanex(plane, p_equation);
					LogFunction("glGetClipPlanex({0}, {1})", LogEnumName(plane), LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFixedv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetFixed(Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFixedv != null, "pglGetFixedv not implemented");
					Delegates.pglGetFixedv(pname, p_params);
					LogFunction("glGetFixedv({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetLightxv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetLightxv(Int32 light, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxv != null, "pglGetLightxv not implemented");
					Delegates.pglGetLightxv(light, pname, p_params);
					LogFunction("glGetLightxv({0}, {1}, {2})", LogEnumName(light), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMaterialxv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetMaterial(Int32 face, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxv != null, "pglGetMaterialxv not implemented");
					Delegates.pglGetMaterialxv(face, pname, p_params);
					LogFunction("glGetMaterialxv({0}, {1}, {2})", LogEnumName(face), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexEnvxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetTexEnv(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvxv != null, "pglGetTexEnvxv not implemented");
					Delegates.pglGetTexEnvxv(target, pname, p_params);
					LogFunction("glGetTexEnvxv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexParameterxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetTexParameter(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterxv != null, "pglGetTexParameterxv not implemented");
					Delegates.pglGetTexParameterxv(target, pname, p_params);
					LogFunction("glGetTexParameterxv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightModelx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LightModel(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightModelx != null, "pglLightModelx not implemented");
			Delegates.pglLightModelx(pname, param);
			LogFunction("glLightModelx({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightModelxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LightModel(Int32 pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglLightModelxv != null, "pglLightModelxv not implemented");
					Delegates.pglLightModelxv(pname, p_param);
					LogFunction("glLightModelxv({0}, {1})", LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightx.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Lightx(Int32 light, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightx != null, "pglLightx not implemented");
			Delegates.pglLightx(light, pname, param);
			LogFunction("glLightx({0}, {1}, 0x{2})", LogEnumName(light), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightxv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Lightxv(Int32 light, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightxv != null, "pglLightxv not implemented");
					Delegates.pglLightxv(light, pname, p_params);
					LogFunction("glLightxv({0}, {1}, {2})", LogEnumName(light), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLineWidthx.
		/// </summary>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LineWidth(IntPtr width)
		{
			Debug.Assert(Delegates.pglLineWidthx != null, "pglLineWidthx not implemented");
			Delegates.pglLineWidthx(width);
			LogFunction("glLineWidthx(0x{0})", width.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLoadMatrixx.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LoadMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixx != null, "pglLoadMatrixx not implemented");
					Delegates.pglLoadMatrixx(p_m);
					LogFunction("glLoadMatrixx({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMaterialx.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Material(Int32 face, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglMaterialx != null, "pglMaterialx not implemented");
			Delegates.pglMaterialx(face, pname, param);
			LogFunction("glMaterialx({0}, {1}, 0x{2})", LogEnumName(face), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMaterialxv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Material(Int32 face, Int32 pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglMaterialxv != null, "pglMaterialxv not implemented");
					Delegates.pglMaterialxv(face, pname, p_param);
					LogFunction("glMaterialxv({0}, {1}, {2})", LogEnumName(face), LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultMatrixx.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void MultMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixx != null, "pglMultMatrixx not implemented");
					Delegates.pglMultMatrixx(p_m);
					LogFunction("glMultMatrixx({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord4x.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void MultiTexCoord4(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4x != null, "pglMultiTexCoord4x not implemented");
			Delegates.pglMultiTexCoord4x(texture, s, t, r, q);
			LogFunction("glMultiTexCoord4x({0}, 0x{1}, 0x{2}, 0x{3}, 0x{4})", LogEnumName(texture), s.ToString("X8"), t.ToString("X8"), r.ToString("X8"), q.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormal3x.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Normal3(IntPtr nx, IntPtr ny, IntPtr nz)
		{
			Debug.Assert(Delegates.pglNormal3x != null, "pglNormal3x not implemented");
			Delegates.pglNormal3x(nx, ny, nz);
			LogFunction("glNormal3x(0x{0}, 0x{1}, 0x{2})", nx.ToString("X8"), ny.ToString("X8"), nz.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glOrthox.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Orthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglOrthox != null, "pglOrthox not implemented");
			Delegates.pglOrthox(l, r, b, t, n, f);
			LogFunction("glOrthox(0x{0}, 0x{1}, 0x{2}, 0x{3}, 0x{4}, 0x{5})", l.ToString("X8"), r.ToString("X8"), b.ToString("X8"), t.ToString("X8"), n.ToString("X8"), f.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointParameterx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointParameter(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterx != null, "pglPointParameterx not implemented");
			Delegates.pglPointParameterx(pname, param);
			LogFunction("glPointParameterx({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointParameterxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointParameter(Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterxv != null, "pglPointParameterxv not implemented");
					Delegates.pglPointParameterxv(pname, p_params);
					LogFunction("glPointParameterxv({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointSizex.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointSize(IntPtr size)
		{
			Debug.Assert(Delegates.pglPointSizex != null, "pglPointSizex not implemented");
			Delegates.pglPointSizex(size);
			LogFunction("glPointSizex(0x{0})", size.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPolygonOffsetx.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PolygonOffset(IntPtr factor, IntPtr units)
		{
			Debug.Assert(Delegates.pglPolygonOffsetx != null, "pglPolygonOffsetx not implemented");
			Delegates.pglPolygonOffsetx(factor, units);
			LogFunction("glPolygonOffsetx(0x{0}, 0x{1})", factor.ToString("X8"), units.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRotatex.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Rotate(IntPtr angle, IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRotatex != null, "pglRotatex not implemented");
			Delegates.pglRotatex(angle, x, y, z);
			LogFunction("glRotatex(0x{0}, 0x{1}, 0x{2}, 0x{3})", angle.ToString("X8"), x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSampleCoveragex.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void SampleCoverage(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragex != null, "pglSampleCoveragex not implemented");
			Delegates.pglSampleCoveragex(value, invert);
			LogFunction("glSampleCoveragex({0}, {1})", value, invert);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glScalex.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Scale(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglScalex != null, "pglScalex not implemented");
			Delegates.pglScalex(x, y, z);
			LogFunction("glScalex(0x{0}, 0x{1}, 0x{2})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexEnvx.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexEnv(Int32 target, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexEnvx != null, "pglTexEnvx not implemented");
			Delegates.pglTexEnvx(target, pname, param);
			LogFunction("glTexEnvx({0}, {1}, 0x{2})", LogEnumName(target), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexEnvxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexEnv(Int32 target, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvxv != null, "pglTexEnvxv not implemented");
					Delegates.pglTexEnvxv(target, pname, p_params);
					LogFunction("glTexEnvxv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexParameterx.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexParameter(Int32 target, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexParameterx != null, "pglTexParameterx not implemented");
			Delegates.pglTexParameterx(target, pname, param);
			LogFunction("glTexParameterx({0}, {1}, 0x{2})", LogEnumName(target), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexParameterxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexParameter(Int32 target, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterxv != null, "pglTexParameterxv not implemented");
					Delegates.pglTexParameterxv(target, pname, p_params);
					LogFunction("glTexParameterxv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTranslatex.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Translate(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglTranslatex != null, "pglTranslatex not implemented");
			Delegates.pglTranslatex(x, y, z);
			LogFunction("glTranslatex(0x{0}, 0x{1}, 0x{2})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlanef", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanef(Int32 p, float* eqn);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustumf", ExactSpelling = true)]
			internal extern static void glFrustumf(float l, float r, float b, float t, float n, float f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlanef", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanef(Int32 plane, float* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrthof", ExactSpelling = true)]
			internal extern static void glOrthof(float l, float r, float b, float t, float n, float f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFuncx", ExactSpelling = true)]
			internal extern static unsafe void glAlphaFuncx(Int32 func, IntPtr @ref);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearColorx", ExactSpelling = true)]
			internal extern static unsafe void glClearColorx(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearDepthx", ExactSpelling = true)]
			internal extern static unsafe void glClearDepthx(IntPtr depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlanex", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanex(Int32 plane, IntPtr* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4x", ExactSpelling = true)]
			internal extern static unsafe void glColor4x(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangex", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangex(IntPtr n, IntPtr f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogx", ExactSpelling = true)]
			internal extern static unsafe void glFogx(Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogxv", ExactSpelling = true)]
			internal extern static unsafe void glFogxv(Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustumx", ExactSpelling = true)]
			internal extern static unsafe void glFrustumx(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlanex", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanex(Int32 plane, IntPtr* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFixedv", ExactSpelling = true)]
			internal extern static unsafe void glGetFixedv(Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetLightxv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMaterialxv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxv(Int32 face, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexEnvxv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelx", ExactSpelling = true)]
			internal extern static unsafe void glLightModelx(Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelxv", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxv(Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightx", ExactSpelling = true)]
			internal extern static unsafe void glLightx(Int32 light, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightxv", ExactSpelling = true)]
			internal extern static unsafe void glLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLineWidthx", ExactSpelling = true)]
			internal extern static unsafe void glLineWidthx(IntPtr width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadMatrixx", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixx(IntPtr* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialx", ExactSpelling = true)]
			internal extern static unsafe void glMaterialx(Int32 face, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialxv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxv(Int32 face, Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultMatrixx", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixx(IntPtr* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord4x", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4x(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3x", ExactSpelling = true)]
			internal extern static unsafe void glNormal3x(IntPtr nx, IntPtr ny, IntPtr nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrthox", ExactSpelling = true)]
			internal extern static unsafe void glOrthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameterx", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterx(Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxv(Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointSizex", ExactSpelling = true)]
			internal extern static unsafe void glPointSizex(IntPtr size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonOffsetx", ExactSpelling = true)]
			internal extern static unsafe void glPolygonOffsetx(IntPtr factor, IntPtr units);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRotatex", ExactSpelling = true)]
			internal extern static unsafe void glRotatex(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSampleCoveragex", ExactSpelling = true)]
			internal extern static void glSampleCoveragex(Int32 value, bool invert);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScalex", ExactSpelling = true)]
			internal extern static unsafe void glScalex(IntPtr x, IntPtr y, IntPtr z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvx", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvx(Int32 target, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvxv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterx", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterx(Int32 target, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTranslatex", ExactSpelling = true)]
			internal extern static unsafe void glTranslatex(IntPtr x, IntPtr y, IntPtr z);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanef(Int32 p, float* eqn);

			[ThreadStatic]
			internal static glClipPlanef pglClipPlanef;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustumf(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glFrustumf pglFrustumf;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanef(Int32 plane, float* equation);

			[ThreadStatic]
			internal static glGetClipPlanef pglGetClipPlanef;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrthof(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glOrthof pglOrthof;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glAlphaFuncx(Int32 func, IntPtr @ref);

			[ThreadStatic]
			internal static glAlphaFuncx pglAlphaFuncx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearColorx(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glClearColorx pglClearColorx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearDepthx(IntPtr depth);

			[ThreadStatic]
			internal static glClearDepthx pglClearDepthx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanex(Int32 plane, IntPtr* equation);

			[ThreadStatic]
			internal static glClipPlanex pglClipPlanex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4x(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[ThreadStatic]
			internal static glColor4x pglColor4x;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDepthRangex(IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glDepthRangex pglDepthRangex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogx(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glFogx pglFogx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogxv(Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glFogxv pglFogxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFrustumx(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glFrustumx pglFrustumx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanex(Int32 plane, IntPtr* equation);

			[ThreadStatic]
			internal static glGetClipPlanex pglGetClipPlanex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFixedv(Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetFixedv pglGetFixedv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetLightxv pglGetLightxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialxv(Int32 face, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetMaterialxv pglGetMaterialxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexEnvxv pglGetTexEnvxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetTexParameterxv pglGetTexParameterxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelx(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glLightModelx pglLightModelx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelxv(Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glLightModelxv pglLightModelxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightx(Int32 light, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glLightx pglLightx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glLightxv pglLightxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLineWidthx(IntPtr width);

			[ThreadStatic]
			internal static glLineWidthx pglLineWidthx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixx(IntPtr* m);

			[ThreadStatic]
			internal static glLoadMatrixx pglLoadMatrixx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialx(Int32 face, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glMaterialx pglMaterialx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialxv(Int32 face, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glMaterialxv pglMaterialxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixx(IntPtr* m);

			[ThreadStatic]
			internal static glMultMatrixx pglMultMatrixx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4x(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[ThreadStatic]
			internal static glMultiTexCoord4x pglMultiTexCoord4x;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3x(IntPtr nx, IntPtr ny, IntPtr nz);

			[ThreadStatic]
			internal static glNormal3x pglNormal3x;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glOrthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[ThreadStatic]
			internal static glOrthox pglOrthox;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterx(Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glPointParameterx pglPointParameterx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterxv(Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glPointParameterxv pglPointParameterxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointSizex(IntPtr size);

			[ThreadStatic]
			internal static glPointSizex pglPointSizex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPolygonOffsetx(IntPtr factor, IntPtr units);

			[ThreadStatic]
			internal static glPolygonOffsetx pglPolygonOffsetx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRotatex(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glRotatex pglRotatex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleCoveragex(Int32 value, bool invert);

			[ThreadStatic]
			internal static glSampleCoveragex pglSampleCoveragex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScalex(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glScalex pglScalex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvx(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexEnvx pglTexEnvx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexEnvxv pglTexEnvxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterx(Int32 target, Int32 pname, IntPtr param);

			[ThreadStatic]
			internal static glTexParameterx pglTexParameterx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glTexParameterxv pglTexParameterxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTranslatex(IntPtr x, IntPtr y, IntPtr z);

			[ThreadStatic]
			internal static glTranslatex pglTranslatex;

		}
	}

}
