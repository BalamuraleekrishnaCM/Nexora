using NUnit.Framework;
using UnityEditor;
namespace Nexora.Tests { public class EditorToolsTests { [Test] public void EntryPointExists()=>Assert.IsNotNull(typeof(Nexora.EditorTools.EditorTools).GetMethod("Open")); } }
