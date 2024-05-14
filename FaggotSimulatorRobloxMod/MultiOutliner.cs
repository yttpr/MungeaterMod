using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace FSRMod
{
    public class MultiSpriteEnemyLayout : EnemyInFieldLayout
    {
        public SpriteRenderer[] OtherRenderers;
        public void Prepare()
        {
            if (OtherRenderers != null) foreach (SpriteRenderer rend in OtherRenderers) rend.material = _enemyMaterialInstance;
        }
        public void UpdateRends()
        {
            Color value = _basicColor;
            if (TurnSelected)
            {
                value = _turnColor;
            }
            else if (TargetSelected)
            {
                value = _targetColor;
            }
            else if (MouseSelected)
            {
                value = _hoverColor;
            }

            float value2 = ((MouseSelected || TargetSelected || TurnSelected) ? 1 : 0);
            if (OtherRenderers != null) foreach (SpriteRenderer rend in OtherRenderers)
                {
                    rend.material.SetColor("_OutlineColor", value);
                    rend.material.SetFloat("_OutlineAlpha", value2);
                }
        }
        public static void BaseIni(Action<EnemyInFieldLayout, int, Vector3> orig, EnemyInFieldLayout self, int id, Vector3 location3D)
        {
            orig(self, id, location3D);
            if (self is MultiSpriteEnemyLayout l) l.Prepare();
        }
        public static void BaseUpi(Action<EnemyInFieldLayout> orig, EnemyInFieldLayout self)
        {
            orig(self);
            if (self is MultiSpriteEnemyLayout l) l.UpdateRends();
        }
        public static void Setup()
        {
            //IDetour hook0 = new Hook(typeof(MultiSpriteEnemyLayout).GetMethod(nameof(Initialization), ~BindingFlags.Default), typeof(MultiSpriteEnemyLayout).GetMethod(nameof(BaseIni), ~BindingFlags.Default));
            //IDetour hook1 = new Hook(typeof(MultiSpriteEnemyLayout).GetMethod(nameof(UpdateSlotSelection), ~BindingFlags.Default), typeof(MultiSpriteEnemyLayout).GetMethod(nameof(BaseUpi), ~BindingFlags.Default));
            IDetour hook2 = new Hook(typeof(EnemyInFieldLayout).GetMethod(nameof(Initialization), ~BindingFlags.Default), typeof(MultiSpriteEnemyLayout).GetMethod(nameof(BaseIni), ~BindingFlags.Default));
            IDetour hook3 = new Hook(typeof(EnemyInFieldLayout).GetMethod(nameof(UpdateSlotSelection), ~BindingFlags.Default), typeof(MultiSpriteEnemyLayout).GetMethod(nameof(BaseUpi), ~BindingFlags.Default));
        }
    }
}
