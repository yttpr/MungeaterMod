using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FSRMod
{
    public static class Prayer
    {
        public static void Add()
        {
            //IDetour addAnestheticsIntentIDetour = (IDetour)new Hook((MethodBase)typeof(IntentHandlerSO).GetMethod("Initialize", ~BindingFlags.Default), typeof(PrayerFool).GetMethod("AnestheticsIntent", ~BindingFlags.Default));
            //IDetour addAnestheticsIDetour = (IDetour)new Hook((MethodBase)typeof(CombatManager).GetMethod("InitializeCombat", ~BindingFlags.Default), typeof(PrayerFool).GetMethod("AddAnestheticsStatusEffect", ~BindingFlags.Default));
            /*PerformEffectPassiveAbility passiveThing = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            ((BasePassiveAbilitySO)passiveThing)._passiveName = "RESET MAXIMU HEALTH";
            ((BasePassiveAbilitySO)passiveThing).passiveIcon = ResourceLoader.LoadSprite("Purple Essence");
            ((BasePassiveAbilitySO)passiveThing).type = (PassiveAbilityTypes)666668;
            ((BasePassiveAbilitySO)passiveThing)._enemyDescription = "This shouldn't be on an enemy.";
            ((BasePassiveAbilitySO)passiveThing)._characterDescription = "purbleEssencepurbleEssencepurbleEssencepurbleEssencepurbleEssence";
            ((BasePassiveAbilitySO)passiveThing).doesPassiveTriggerInformationPanel = false;
            DamageEffect indirect = ScriptableObject.CreateInstance<DamageEffect>();
            indirect._indirect = true;
            passiveThing.effects = ExtensionMethods.ToEffectInfoArray(new Effect[1]
            {
                new Effect(indirect, 1, IntentType.Misc, Slots.Self)
            });
            ((BasePassiveAbilitySO)passiveThing)._triggerOn = new TriggerCalls[2]
            {
                //(TriggerCalls)987765
                TriggerCalls.OnCombatStart, TriggerCalls.OnMaxHealthChanged
            };
            NoHealPassiveAbility CUSTOMDYING = ScriptableObject.CreateInstance<NoHealPassiveAbility>();
            CUSTOMDYING._triggerOn = new TriggerCalls[1] { TriggerCalls.CanHeal };
            CUSTOMDYING._passiveName = "die";
            //CUSTOMDYING.passiveIcon = ResourceLoader.LoadSprite("SPRITTEEEE");
            CUSTOMDYING.type = (PassiveAbilityTypes)666666;
            CUSTOMDYING._enemyDescription = "This shouldn't be on an enemy... or should it?";
            CUSTOMDYING._characterDescription = "lol";
            */
            //CUSTOMDYING.doesPassiveTriggerInformationPanel = false;
            //CUSTOMDYING.effects = ExtensionMethods.ToEffectInfoArray(new Effect[0] { });

            /*
            NoMaxHealthChangePassiveAbility testingTHIS = ScriptableObject.CreateInstance<NoMaxHealthChangePassiveAbility>();
            testingTHIS._passiveName = "NO MAX HEALTHING LOOL";
            testingTHIS.passiveIcon = ResourceLoader.LoadSprite("Purple Essence");
            testingTHIS.type = (PassiveAbilityTypes)666669;
            testingTHIS._enemyDescription = "This shouldn't be on an enemy.";
            testingTHIS._characterDescription = "max health change is all 0";
            testingTHIS._triggerOn = new TriggerCalls[1] { TriggerCalls.OnAnyAbilityUsed };
            Debug.Log("passive sprite");
            */
            /*
            StatusSharePassiveAbility testingTHIS = ScriptableObject.CreateInstance<StatusSharePassiveAbility>();
            testingTHIS._passiveName = "testen";
            testingTHIS.passiveIcon = ResourceLoader.LoadSprite("Purple Essence");
            Debug.Log("1?");
            testingTHIS.type = (PassiveAbilityTypes)666669;
            testingTHIS._enemyDescription = "This shouldn't be on an enemy.";
            testingTHIS._characterDescription = "share status effect";
            /*PerformRandomAbilityEffect instance2 = ScriptableObject.CreateInstance<PerformRandomAbilityEffect>();
            testingTHIS.effects = ExtensionMethods.ToEffectInfoArray(new Effect[1]
            {
        new Effect((EffectSO) instance2, 1, new IntentType?(), Slots.Self)
            });*/
            /*
            testingTHIS._triggerOn = new TriggerCalls[1]
            {
                TriggerCalls.Count
            };
            testingTHIS.doesPassiveTriggerInformationPanel = false;

            /*
            /*ApplyStunnedEffect instance3 = ScriptableObject.CreateInstance<ApplyStunnedEffect>();
            testingTHIS._secondEffects = ExtensionMethods.ToEffectInfoArray(new Effect[1]
            {
        new Effect((EffectSO) instance3, 1, new IntentType?(), Slots.Self)
            });
            testingTHIS._secondTriggerOn = new TriggerCalls[1]
            {
        TriggerCalls.OnTurnStart
            };*/

            //LoadedAssetsHandler.GetCharcater("Hans_CH").rankedData[0].rankAbilities[1].
            /*
            PerformDoubleEffectPassiveAbility hideHP = ScriptableObject.CreateInstance<PerformDoubleEffectPassiveAbility>();
            hideHP._passiveName = "Placeholder name";
            hideHP.passiveIcon = ResourceLoader.LoadSprite("Purple Essence");
            hideHP.type = (PassiveAbilityTypes)544522;
            hideHP._enemyDescription = "placeholder description.";
            hideHP._characterDescription = "placeholder description";
            hideHP.doesPassiveTriggerInformationPanel = false;
            hideHP.effects = ExtensionMethods.ToEffectInfoArray(new Effect[2] { new Effect(ScriptableObject.CreateInstance<UnhideDamageEffect>(), 1, new IntentType?(), Slots.Self), new Effect(ScriptableObject.CreateInstance<UnhideHealEffect>(), 1, new IntentType?(), Slots.Self) });
            hideHP._triggerOn = new TriggerCalls[2] { TriggerCalls.OnDeath, TriggerCalls.OnCombatEnd };
            hideHP._secondDoesPerformPopUp = false;
            hideHP._secondEffects = ExtensionMethods.ToEffectInfoArray(new Effect[2] { new Effect(ScriptableObject.CreateInstance<HideDamageEffect>(), 1, new IntentType?(), Slots.Self), new Effect(ScriptableObject.CreateInstance<HideHealEffect>(), 1, new IntentType?(), Slots.Self) });
            hideHP._secondTriggerOn = new TriggerCalls[2] { TriggerCalls.OnCombatStart, TriggerCalls.OnTurnStart };
            */
            /*
            PerformEffectPassiveAbility changeDeathToObliteration = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            changeDeathToObliteration._passiveName = "Placeholder name";
            changeDeathToObliteration.passiveIcon = ResourceLoader.LoadSprite("Purple Essence");
            changeDeathToObliteration.type = (PassiveAbilityTypes)544522;
            changeDeathToObliteration._enemyDescription = "placeholder description.";
            changeDeathToObliteration._characterDescription = "changes death type to obliteration";
            changeDeathToObliteration.doesPassiveTriggerInformationPanel = false;
            changeDeathToObliteration.conditions = new EffectorConditionSO[1]
            {
                ScriptableObject.CreateInstance<ChangeDeathToObliterationEffectorCondition>()
            };
            changeDeathToObliteration.effects = ExtensionMethods.ToEffectInfoArray(new Effect[1] { new Effect(ScriptableObject.CreateInstance<ExitValueSetterEffect>(), 1, new IntentType?(), Slots.Self) });
            changeDeathToObliteration._triggerOn = new TriggerCalls[1] { TriggerCalls.CanDie };
            */

            Character remnant = new Character();
            remnant.name = "Prayer";
            remnant.healthColor = Pigments.Purple;
            remnant.entityID = (EntityIDs)86383;
            //remnant.characterID = "Prayer_Fool";
            /*
            remnant.overworldSprite = ResourceLoader.LoadSprite("pray overworld in-size", 32, new Vector2(0.5f, 0));
            remnant.frontSprite = ResourceLoader.LoadSprite("pray front in-size");
            remnant.backSprite = ResourceLoader.LoadSprite("pray back in-size");
            remnant.lockedSprite = ResourceLoader.LoadSprite("pray locked in-size");
            remnant.unlockedSprite = ResourceLoader.LoadSprite("pray unlocked in-size");
            */

            remnant.overworldSprite = ResourceLoader.LoadSprite("PrayerOverworld", 32, new Vector2(0.5f, 0));
            remnant.frontSprite = ResourceLoader.LoadSprite("PrayerFront");
            remnant.backSprite = ResourceLoader.LoadSprite("PrayerBack");
            remnant.lockedSprite = ResourceLoader.LoadSprite("PrayerLocked");
            remnant.unlockedSprite = ResourceLoader.LoadSprite("PrayerUnlocked");

            remnant.passives = new BasePassiveAbilitySO[]
            {
                //Passives.Withering,
                //hideHP
                //changeDeathToObliteration,
                //testingTHIS
            };
            remnant.menuChar = true;
            remnant.isSupport = false;
            remnant.walksInOverworld = true;
            remnant.hurtSound = LoadedAssetsHandler.GetEnemy("SkinningHomunculus_EN").damageSound;
            remnant.deathSound = LoadedAssetsHandler.GetEnemy("SkinningHomunculus_EN").deathSound;
            Debug.Log("THE CHARACTER");

            //character.levels = new CharacterRankedData[1];
            /*
            Ability PatienceAbility = new Ability();
            PatienceAbility.name = "Patience";
            PatienceAbility.description = "Produce 1 purple pigment, 95% chance to produce an additional one. 5% chance to refresh this party member's ability usage.";
            PatienceAbility.cost = new ManaColorSO[1] { Pigments.Yellow };
            PatienceAbility.sprite = ResourceLoader.LoadSprite("Patience Prayer");
            PatienceAbility.effects = new Effect[3];
            PatienceAbility.effects[0] = new Effect(ScriptableObject.CreateInstance<GenerateColorManaEffect>(), 1, new IntentType?(IntentType.Mana_Generate), Slots.Self);
            ((GenerateColorManaEffect)PatienceAbility.effects[0]._effect).mana = Pigments.Purple;
            PatienceAbility.effects[1] = new Effect(ScriptableObject.CreateInstance<GenerateColorManaEffect>(), 1, new IntentType?(), Slots.Self, Conditions.Chance(95));
            ((GenerateColorManaEffect)PatienceAbility.effects[1]._effect).mana = Pigments.Purple;
            PatienceAbility.effects[2] = new Effect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, new IntentType?(IntentType.Other_Refresh), Slots.Self, Conditions.Chance(10));
            PatienceAbility.visuals = LoadedAssetsHandler.GetEnemy("Mung_EN").abilities[1].ability.visuals;
            PatienceAbility.animationTarget = Slots.Self;
            //remnant.baseAbility = PatienceAbility;

            Ability soul0 = new Ability();
            soul0.name = "Pain the Soul";
            soul0.description = "Apply 1 frail and deal 4 damage to the opposing enemy.";
            soul0.cost = new ManaColorSO[2] { Pigments.Purple, Pigments.Purple };
            soul0.sprite = ResourceLoader.LoadSprite("Hit the Soul");
            soul0.effects = new Effect[2];
            soul0.effects[0] = new Effect(ScriptableObject.CreateInstance<ApplyFrailEffect>(), 1, new IntentType?(IntentType.Status_Frail), Slots.Front);
            soul0.effects[1] = new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 4, new IntentType?(IntentType.Damage_3_6), Slots.Front);
            soul0.visuals = LoadedAssetsHandler.GetEnemy("ChoirBoy_EN").abilities[2].ability.visuals;
            soul0.animationTarget = Slots.Front;

            Ability mind0 = new Ability();
            mind0.name = "Shock the Mind";
            mind0.description = "Deal 5 damage to the left and right enemies.";
            mind0.cost = new ManaColorSO[3] { Pigments.Red, Pigments.Purple, Pigments.Purple };
            mind0.sprite = ResourceLoader.LoadSprite("Hit the Mind");
            mind0.effects = new Effect[1];
            mind0.effects[0] = new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 5, new IntentType?(IntentType.Damage_3_6), Slots.LeftRight);
            mind0.visuals = LoadedAssetsHandler.GetEnemy("HeavensGateRed_BOSS").abilities[1].ability.visuals;
            mind0.animationTarget = Slots.LeftRight;

            Ability body0 = new Ability();
            body0.name = "Fester the Body";
            body0.description = "Apply 1 scar and deal 7 damage to the opposing enemy.";
            body0.cost = new ManaColorSO[3] { Pigments.Blue, Pigments.Purple, Pigments.Purple };
            body0.sprite = ResourceLoader.LoadSprite("Hit the Body");
            body0.effects = new Effect[2];
            body0.effects[0] = new Effect(ScriptableObject.CreateInstance<ApplyScarsEffect>(), 1, new IntentType?(IntentType.Status_Scars), Slots.Front);
            body0.effects[1] = new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 7, new IntentType?(IntentType.Damage_7_10), Slots.Front);
            body0.visuals = LoadedAssetsHandler.GetEnemy("Charcarrion_Alive_BOSS").abilities[2].ability.visuals;
            body0.animationTarget = Slots.Front;

            Ability soul1 = soul0.Duplicate();
            soul1.name = "Assault the Soul";
            soul1.description = "Apply 1 frail and deal 5 damage to the opposing enemy.";
            soul1.effects[0]._entryVariable = 2;
            soul1.effects[1]._entryVariable = 5;
            Ability mind1 = mind0.Duplicate();
            mind1.name = "Assault the Minds";
            mind1.description = "Deal 8 damage to the left and right enemies.";
            mind1.effects[0]._entryVariable = 8;
            mind1.effects[0]._intent = new IntentType?(IntentType.Damage_7_10);
            Ability body1 = body0.Duplicate();
            body1.name = "Rot the Body";
            body1.description = "Apply 1-2 scars and deal 8 damage to the opposing enemy.";
            body1.effects[0] = new Effect(ScriptableObject.CreateInstance<ScarsInRangeFromOneEffect>(), 1, new IntentType?(IntentType.Status_Scars), Slots.Front);
            body1.effects[1]._entryVariable = 8;

            Ability soul2 = soul1.Duplicate();
            soul2.name = "Tear the Soul";
            soul2.description = "Apply 2 frail and deal 6 damage to the opposing enemy.";
            soul2.effects[0]._entryVariable = 2;
            soul2.effects[1]._entryVariable = 6;
            soul2.cost = new ManaColorSO[2] { Pigments.Purple, Pigments.SplitPigment(Pigments.Purple, Pigments.Red) };
            Ability mind2 = mind1.Duplicate();
            mind2.name = "Panic the Minds";
            mind2.description = "Deal 10 damage to the left and right enemies.";
            mind2.effects[0]._entryVariable = 10;
            Ability body2 = body1.Duplicate();
            body2.name = "Decompose the Body";
            body2.description = "Apply 2 scars and deal 9 damage to the opposing enemy.";
            body2.effects[0] = new Effect(ScriptableObject.CreateInstance<ApplyScarsEffect>(), 2, new IntentType?(IntentType.Status_Scars), Slots.Front);
            body2.effects[1]._entryVariable = 9;
            body2.effects[1]._intent = new IntentType?(IntentType.Damage_7_10);
            body2.cost = new ManaColorSO[2] { Pigments.Blue, Pigments.Purple };

            Ability soul3 = soul2.Duplicate();
            soul3.name = "Destroy the Soul";
            soul3.description = "Apply 3 frail and deal 7 damage to the opposing enemy.";
            soul3.effects[0]._entryVariable = 3;
            soul3.effects[1]._entryVariable = 7;
            soul3.effects[1]._intent = new IntentType?(IntentType.Damage_7_10);
            Ability mind3 = mind2.Duplicate();
            mind3.name = "Terrorize the Minds";
            mind3.description = "Deal 10 damage to the left, opposing, and right enemies.";
            mind3.effects[0]._target = Slots.FrontLeftRight;
            mind3.animationTarget = Slots.FrontLeftRight;
            mind3.effects[0]._entryVariable = 12;
            mind3.cost = new ManaColorSO[3] { Pigments.Red, Pigments.Purple, Pigments.SplitPigment(Pigments.Purple, Pigments.Yellow) };
            Ability body3 = body2.Duplicate();
            body3.name = "Disintegrate the Body";
            body3.description = "Apply 2-3 scars and deal 10 damage to the opposing enemy.";
            body3.effects[0] = new Effect(ScriptableObject.CreateInstance<ScarsInRangeFromTwoEffect>(), 1, new IntentType?(IntentType.Status_Scars), Slots.Front);
            body3.effects[1]._entryVariable = 10;
            body3.cost = new ManaColorSO[2] { Pigments.SplitPigment(Pigments.Blue, Pigments.Purple), Pigments.Purple };
            Debug.Log("stuff not added");
            */
            /*
            remnant.AddLevel(12, new Ability[3]
            {
                soul0,
                mind0,
                body0
            }, 0);
            remnant.AddLevel(16, new Ability[3]
            {
                soul1,
                mind1,
                body1
            }, 1);
            remnant.AddLevel(20, new Ability[3]
            {
                soul2,
                mind2,
                body2
            }, 2);
            remnant.AddLevel(24, new Ability[3]
            {
                soul3,
                mind3,
                body3
            }, 3);


            remnant.AddCharacter();
            */

            PreviousEffectCondition didThat = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            didThat.wasSuccessful = true; //this means this condition only allows it's effect to run if the previous one returned true.
            //for damage effects, such as DamageEffect, they return true if they managed to deal damage more than 1. 
            //this means being blocked by shields or divine protection, or just not hitting anything, returns false

            /*
            Ability nameLol = new Ability();
            nameLol.name = "NAME LOL!";
            nameLol.description = "deal 4 damage to the right ally. If damage was dealt, apply Focused to self and the right ally.";
            nameLol.cost = new ManaColorSO[2] { Pigments.Blue, Pigments.Red };
            nameLol.sprite = ResourceLoader.LoadSprite("SPRITE!!!!");
            nameLol.effects = new Effect[2];
            nameLol.effects[0] = new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 4, IntentType.Damage_3_6, Slots.SlotTarget(new int[] { 1 }, true));
            //this deals 4 damage to the right ally.
            nameLol.effects[1] = new Effect(ScriptableObject.CreateInstance<ApplyFocusedEffect>(), 1, IntentType.Status_Focused, Slots.SlotTarget(new int[] { 0, 1 }, true), didThat);
            //this applies focused to the right ally and self based on the condition that has been set.
            //putting this "didThat" at the end of the effect after the targetting sets the condition of the effect. 
            //the condition is described above where we created "didThat"
            nameLol.visuals = LoadedAssetsHandler.GetEnemyAbility("Chomp_A").visuals;
            //you can also get character abilities by using LoadedAssetsHandler.GetCharacterAbility("the name of the ability").visuals;
            //i'll link you the spreadsheet with the internal names of all the abilities. it also contains names for characters and enemies too
            nameLol.animationTarget = Slots.SlotTarget(new int[] { 1 }, true);
            //dont forget to set the targetting for your animations!
            */


            CasterStoredValueChangeEffect INCREASEVOICEES = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            INCREASEVOICEES._minimumValue = 0;
            INCREASEVOICEES._valueName = (UnitStoredValueNames)441921;
            INCREASEVOICEES._increase = true;

            ChangeMaxHealthEffect maxUP = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            maxUP._increase = true;
            ChangeMaxHealthEffect maxDown = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            maxDown._increase = false;

            Targetting_ByUnit_Side allAlly = ScriptableObject.CreateInstance<Targetting_ByUnit_Side>();
            allAlly.getAllies = true;
            allAlly.getAllUnitSlots = false;

            Ability test = new Ability();
            test.name = "TEST";
            test.description = "tset";
            test.cost = new ManaColorSO[0] { };
            test.sprite = ResourceLoader.LoadSprite("Hit the Soul");
            test.effects = new Effect[2];
            //test.effects[0] = new Effect(ScriptableObject.CreateInstance<ApplyBoostedEffect>(), 2, (IntentType)327730, Slots.Self);
            //test.effects[0] = new Effect(ScriptableObject.CreateInstance<CycleAllSlotsEffect>(), 3, IntentType.Misc, Slots.Self);
            test.effects[1] = new Effect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 4, new IntentType?(IntentType.Other_Refresh), Slots.Self);
            //test.effects[3] = new Effect(ScriptableObject.CreateInstance<ApplyPaleEffect>(), 5, (IntentType)846743, Slots.Front);
            /*
            ChangeMaxHealthEffect decMax = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            decMax._increase = false;

            test.visuals = LoadedAssetsHandler.GetEnemy("ChoirBoy_EN").abilities[2].ability.visuals;
            test.animationTarget = Slots.Front;
            Ability test2 = new Ability();
            test2.name = "TEST2";
            test2.description = "decrease max health";
            test2.cost = new ManaColorSO[0] { };
            test2.sprite = ResourceLoader.LoadSprite("Hit the Soul");
            test2.effects = new Effect[2];
            test2.effects[0] = new Effect(decMax, 1, IntentType.Other_MaxHealth, Slots.Self);
            test2.effects[1] = new Effect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 4, new IntentType?(IntentType.Other_Refresh), Slots.Self);
            test2.visuals = LoadedAssetsHandler.GetEnemy("ChoirBoy_EN").abilities[2].ability.visuals;
            test2.animationTarget = Slots.Front;
            Debug.Log("shit");
            Ability test3 = new Ability();
            test3.name = "TEST3";
            test3.description = "fuck resolution";
            test3.cost = new ManaColorSO[0] { };
            test3.sprite = ResourceLoader.LoadSprite("Hit the Soul");
            test3.effects = new Effect[2];
            test3.effects[0] = new Effect(ScriptableObject.CreateInstance<MurderScreenResolutionEffect>(), 1, IntentType.Status_DivineProtection, Slots.Self);
            test3.effects[1] = new Effect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 4, new IntentType?(IntentType.Other_Refresh), Slots.Self);
            test3.visuals = LoadedAssetsHandler.GetEnemy("ChoirBoy_EN").abilities[2].ability.visuals;
            test3.animationTarget = Slots.Front;
            Debug.Log("shit");
            //DamageEffect indirect = ScriptableObject.CreateInstance<DamageEffect>();
            //indirect._indirect = true;
            Ability test4 = new Ability();
            test4.name = "TEST4";
            test4.description = "un-fuck resolution";
            test4.cost = new ManaColorSO[0] { };
            test4.sprite = ResourceLoader.LoadSprite("Hit the Soul");
            test4.effects = new Effect[2];
            test4.effects[0] = new Effect(ScriptableObject.CreateInstance<UnMurderScreenResolutionEffect>(), 1, IntentType.Damage_1_2, Slots.Self);
            test4.effects[1] = new Effect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 4, new IntentType?(IntentType.Other_Refresh), Slots.Self);
            test4.visuals = LoadedAssetsHandler.GetEnemy("ChoirBoy_EN").abilities[2].ability.visuals;
            test4.animationTarget = Slots.Front;
            Debug.Log("shit");
            */
            /*
            IDetour addPaleIDetour = (IDetour)new Hook((MethodBase)typeof(CombatManager).GetMethod("InitializeCombat", ~BindingFlags.Default), typeof(PrayerFool).GetMethod("AddPaleStatusEffect", ~BindingFlags.Default));
            IDetour addPaleIntentIDetour = (IDetour)new Hook((MethodBase)typeof(IntentHandlerSO).GetMethod("Initialize", ~BindingFlags.Default), typeof(PrayerFool).GetMethod("PaleIntent", ~BindingFlags.Default));
            */


            remnant.levels = new CharacterRankedData[1];
            remnant.usesAllAbilities = true;
            remnant.AddLevel(11, new Ability[] { test }, 0);
            remnant.AddCharacter();
            Debug.Log("huh??");

            /*CustomInanimatePassiveAbility customInanimate = ScriptableObject.CreateInstance<CustomInanimatePassiveAbility>();
            customInanimate._passiveName = "Inanimate";
            customInanimate.passiveIcon = ResourceLoader.LoadSprite("Grab the sprite");
            customInanimate.type = PassiveAbilityTypes.Inanimate;
            customInanimate._enemyDescription = "...";
            customInanimate._characterDescription = "Something something description";
            customInanimate._triggerOn = new TriggerCalls[2]
            {
                TriggerCalls.CanApplyStatusEffect,
                TriggerCalls.CanHeal
            };*/

            /*
            EffectItem fish = new EffectItem();
            fish.name = "item :)";
            fish.sprite = ResourceLoader.LoadSprite("PassivePlaceholder");
            fish.description = "lalala";
            fish.itemPools = ItemPools.Fish;
            fish.consumeTrigger = TriggerCalls.Count;
            fish.effects = new Effect[1] { new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 2, null, Slots.Front) };
            fish.trigger = TriggerCalls.Count;
            fish.AddItem();
            */
        }
    }
}
