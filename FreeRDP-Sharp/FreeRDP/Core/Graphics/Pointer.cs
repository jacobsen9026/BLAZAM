/**
 * FreeRDP: A Remote Desktop Protocol Implementation
 * Pointer
 *
 * Copyright 2011-2012 Marc-Andre Moreau <marcandre.moreau@gmail.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.InteropServices;

namespace FreeRDP
{
	public unsafe delegate void pPointer_New(rdpContext* context, rdpPointer* pointer);
	public unsafe delegate void pPointer_Free(rdpContext* context, rdpPointer* pointer);
	public unsafe delegate void pPointer_Set(rdpContext* context, rdpPointer* pointer);
	
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct rdpPointer
	{
		public IntPtr size;
		public IntPtr New;
		public IntPtr Free;
		public IntPtr Set;
		public fixed UInt32 paddingA[16-4];
		
		public UInt32 xPos;
		public UInt32 yPos;
		public UInt32 width;
		public UInt32 height;
		public UInt32 xorBpp;
		public UInt32 lengthAndMask;
		public UInt32 lengthXorMask;
		public IntPtr xorMaskData;
		public IntPtr andMaskData;
		public fixed UInt32 paddingB[32-25];
	}
}
