using System;
using System.Collections.Generic;
using UnityEngine;

internal class GlobalUpdate : Helpers.Singleton<GlobalUpdate>
{
    private List<IUpdate> inUpdate = new List<IUpdate>();
    private List<IFixedUpdate> inFixUpdate = new List<IFixedUpdate>();
    private List<ILateUpdate> inLateUpdate = new List<ILateUpdate>();

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        GlobalUpdate addedInstance = new GameObject($"###{nameof(GlobalUpdate)}###").AddComponent<GlobalUpdate>();
        addedInstance.Awake();
    }

    internal static void AddToUpdate(IUpdater obj)
    {
        if (!Instance) return;
        
        if (obj is IUpdate update)
        {
            if (Instance.inUpdate.Contains(update)) return;
            Instance.inUpdate.Add(update);
        }

        if (obj is IFixedUpdate fUpdate)
        {
            if (Instance.inFixUpdate.Contains(fUpdate)) return;
            Instance.inFixUpdate.Add(fUpdate);
        }

        if (obj is ILateUpdate lUpdate)
        {
            if (Instance.inLateUpdate.Contains(lUpdate)) return;
            Instance.inLateUpdate.Add(lUpdate);
        }
    }

    internal static void RemoveFromUpdate(IUpdater obj)
    {
        if (!Instance) return;
        
        if (obj is IUpdate update)
        {
            if (!Instance.inUpdate.Contains(update)) return;
            Instance.inUpdate.Remove(update);
        }

        if (obj is IFixedUpdate fUpdate)
        {
            if (!Instance.inFixUpdate.Contains(fUpdate)) return;
            Instance.inFixUpdate.Remove(fUpdate);
        }

        if (obj is ILateUpdate lUpdate)
        {
            if (!Instance.inLateUpdate.Contains(lUpdate)) return;
            Instance.inLateUpdate.Remove(lUpdate);
        }
    }

    private void Update()
    {
        for (int i = 0; i < inUpdate.Count; i++)
        {
            try
            {
                inUpdate[i].GUpdate();
            }
            catch (Exception e)
            {
                Debug.LogError($"{e.Message} error\n" +
                               $"In {inUpdate[i].GetType()}");
                throw;
            }
        }
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < inFixUpdate.Count; i++)
        {
            try
            {
                inFixUpdate[i].GFixedUpdate();
            }
            catch (Exception e)
            {
                Debug.LogError($"{e.Message} error\n" +
                               $"In {inFixUpdate[i].GetType()}");
                throw;
            }
        }
    }

    private void LateUpdate()
    {
        for (int i = 0; i < inLateUpdate.Count; i++)
        {
            try
            {
                inLateUpdate[i].GLateUpdate();
            }
            catch (Exception e)
            {
                Debug.LogError($"{e.Message} error\n" +
                               $"In {inLateUpdate[i].GetType()}");
                throw;
            }
        }
    }
}
