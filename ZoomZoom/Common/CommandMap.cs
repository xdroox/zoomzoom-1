// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Common.CommandMap
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace ZoomZoom.Common
{
  [TypeDescriptionProvider(typeof (CommandMap.CommandMapDescriptionProvider))]
  public class CommandMap
  {
    private Dictionary<string, ICommand> _commands;

    protected Dictionary<string, ICommand> Commands
    {
      get
      {
label_1:
        int num1 = 2142823157;
        Dictionary<string, ICommand> commands;
        while (true)
        {
          int num2 = 1972581688;
          uint num3;
          bool flag;
          switch ((num3 = (uint) (num1 ^ num2)) % 7U)
          {
            case 0:
              int num4 = !flag ? 1492673057 : (num4 = 1103866590);
              int num5 = (int) num3 * -630776835;
              num1 = num4 ^ num5;
              continue;
            case 1:
              num1 = (int) num3 * 384004719 ^ -723574656;
              continue;
            case 2:
              goto label_1;
            case 3:
              this._commands = new Dictionary<string, ICommand>();
              num1 = (int) num3 * -1513050387 ^ -137300009;
              continue;
            case 4:
              commands = this._commands;
              num1 = 943462538;
              continue;
            case 6:
              flag = this._commands == null;
              num1 = (int) num3 * 1460180449 ^ -70514073;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return commands;
      }
    }

    public int Count
    {
      get
      {
        bool flag = this._commands != null;
label_1:
        int num1 = -1914867760;
        int num2;
        while (true)
        {
          int num3 = -1217916438;
          uint num4;
          switch ((num4 = (uint) (num1 ^ num3)) % 5U)
          {
            case 0:
              goto label_1;
            case 2:
              num2 = 0;
              num1 = -50015506;
              continue;
            case 3:
              int num5 = !flag ? -367540096 : (num5 = -1377988879);
              int num6 = (int) num4 * -1122618317;
              num1 = num5 ^ num6;
              continue;
            case 4:
              num2 = this._commands.Count;
              num1 = (int) num4 * 1724517954 ^ -1705811324;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return num2;
      }
    }

    public CommandMap()
    {
label_1:
      int num1 = 177032441;
      while (true)
      {
        int num2 = 1722855805;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num3 * 1095749877 ^ -14079120;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public void AddCommand(string commandName, Action<object> executeMethod)
    {
      this.Commands[commandName] = (ICommand) new CommandMap.DelegateCommand(executeMethod);
label_1:
      int num1 = 397445828;
      while (true)
      {
        int num2 = 133791889;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * -1728834181 ^ 1399482907;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    public void AddCommand(string commandName, Action<object> executeMethod, Predicate<object> canExecuteMethod)
    {
      this.Commands[commandName] = (ICommand) new CommandMap.DelegateCommand(executeMethod, canExecuteMethod);
    }

    public void RemoveCommand(string commandName)
    {
label_1:
      int num1 = -1865771323;
      while (true)
      {
        int num2 = -651114687;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Commands.Remove(commandName);
            num1 = (int) num3 * -109417818 ^ 1402607102;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }

    private class DelegateCommand : ICommand
    {
      private Predicate<object> _canExecuteMethod;
      private Action<object> _executeMethod;

      public event EventHandler CanExecuteChanged
      {
        add
        {
          CommandMap.DelegateCommand.\u202B⁭⁫⁫‏⁪‎‫⁯‮‍​⁫‫‫‪‎⁪​⁮‪‪‏‎⁯‮‍‮‫‭‮⁮‏⁭⁮⁫⁯‭‮⁭‮(value);
        }
        remove
        {
label_1:
          int num1 = -827379059;
          while (true)
          {
            int num2 = -1969761891;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                CommandMap.DelegateCommand.\u202A‌​‮‎⁪‌‭⁯‌‪⁬‪‍‮⁮⁪‬⁯⁭‮‭⁫‏‮‍‬⁪‮‏‬‬‪⁭⁯‪‬⁭‭‏‮(value);
                num1 = (int) num3 * -1586040955 ^ -2124334566;
                continue;
              case 2:
                goto label_3;
              default:
                goto label_5;
            }
          }
label_5:
          return;
label_3:;
        }
      }

      public DelegateCommand(Action<object> executeMethod)
        : this(executeMethod, (Predicate<object>) null)
      {
      }

      public DelegateCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
      {
        if (executeMethod == null)
          throw CommandMap.DelegateCommand.\u206A⁭⁪⁯⁪‍‍‍‭‌⁪⁫‪⁮⁯‏‭⁬⁭⁫‏⁮‌‪​⁬⁯‫‮‍⁪⁬‫‫⁮⁭‎‌‫‪‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2478247181U));
        this._executeMethod = executeMethod;
        this._canExecuteMethod = canExecuteMethod;
      }

      public bool CanExecute(object parameter)
      {
label_1:
        int num1 = -1319766178;
        bool flag;
        while (true)
        {
          int num2 = -1267005065;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              if (this._canExecuteMethod != null)
              {
                num1 = (int) num3 * -583945675 ^ 789702944;
                continue;
              }
              num4 = 1;
              break;
            case 2:
              num4 = this._canExecuteMethod(parameter) ? 1 : 0;
              break;
            case 3:
              goto label_1;
            default:
              goto label_8;
          }
          flag = num4 != 0;
          num1 = -1527461285;
        }
label_8:
        return flag;
      }

      public void Execute(object parameter)
      {
        this._executeMethod(parameter);
      }

      static ArgumentNullException \u206A⁭⁪⁯⁪‍‍‍‭‌⁪⁫‪⁮⁯‏‭⁬⁭⁫‏⁮‌‪​⁬⁯‫‮‍⁪⁬‫‫⁮⁭‎‌‫‪‮([In] string obj0)
      {
        return new ArgumentNullException(obj0);
      }

      static void \u202B⁭⁫⁫‏⁪‎‫⁯‮‍​⁫‫‫‪‎⁪​⁮‪‪‏‎⁯‮‍‮‫‭‮⁮‏⁭⁮⁫⁯‭‮⁭‮([In] EventHandler obj0)
      {
        CommandManager.RequerySuggested += obj0;
      }

      static void \u202A‌​‮‎⁪‌‭⁯‌‪⁬‪‍‮⁮⁪‬⁯⁭‮‭⁫‏‮‍‬⁪‮‏‬‬‪⁭⁯‪‬⁭‭‏‮([In] EventHandler obj0)
      {
        CommandManager.RequerySuggested -= obj0;
      }
    }

    private class CommandMapDescriptionProvider : TypeDescriptionProvider
    {
      public CommandMapDescriptionProvider()
        : this(CommandMap.CommandMapDescriptionProvider.\u206F‫⁭‬‬⁯⁫⁭⁮‏‎‌‭‍‫‌‬​‎‎‏‭⁫‬⁬‎‬⁫‮‮‫‪⁯⁪⁫⁯⁬‪⁭‪‮(CommandMap.CommandMapDescriptionProvider.\u200B⁫‍‍⁬‎⁬⁪‌⁭‬‌‫‎⁭‏‌‬‭⁭⁫⁪‍⁪‭⁮⁬⁪‫‭​⁯⁬‪‪⁫‪‏⁬⁪‮(__typeref (CommandMap))))
      {
        // ISSUE: type reference (out of statement scope)
      }

      public CommandMapDescriptionProvider(TypeDescriptionProvider parent)
        : base(parent)
      {
      }

      public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
      {
label_1:
        int num1 = -1345268980;
        ICustomTypeDescriptor customTypeDescriptor;
        while (true)
        {
          int num2 = -1427280839;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              customTypeDescriptor = (ICustomTypeDescriptor) new CommandMap.CommandMapDescriptor(this.\u200F⁪‍⁬‪‭‎‫‪‍⁪⁯​⁫⁮⁮‪‏⁪‭‬⁭‮‌⁮⁪‌‫⁫‫⁯‪⁪‫‪​⁬‫‍‫‮(objectType, instance), instance as CommandMap);
              num1 = (int) num3 * -1030015881 ^ 1653340324;
              continue;
            case 2:
              num1 = (int) num3 * -721985131 ^ 2005619748;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return customTypeDescriptor;
      }

      static Type \u200B⁫‍‍⁬‎⁬⁪‌⁭‬‌‫‎⁭‏‌‬‭⁭⁫⁪‍⁪‭⁮⁬⁪‫‭​⁯⁬‪‪⁫‪‏⁬⁪‮([In] RuntimeTypeHandle obj0)
      {
        return Type.GetTypeFromHandle(obj0);
      }

      static TypeDescriptionProvider \u206F‫⁭‬‬⁯⁫⁭⁮‏‎‌‭‍‫‌‬​‎‎‏‭⁫‬⁬‎‬⁫‮‮‫‪⁯⁪⁫⁯⁬‪⁭‪‮([In] Type obj0)
      {
        return TypeDescriptor.GetProvider(obj0);
      }

      ICustomTypeDescriptor \u200F⁪‍⁬‪‭‎‫‪‍⁪⁯​⁫⁮⁮‪‏⁪‭‬⁭‮‌⁮⁪‌‫⁫‫⁯‪⁪‫‪​⁬‫‍‫‮([In] Type obj0, [In] object obj1)
      {
        return base.GetTypeDescriptor(obj0, obj1);
      }
    }

    private class CommandMapDescriptor : CustomTypeDescriptor
    {
      private CommandMap _map;

      public CommandMapDescriptor(ICustomTypeDescriptor descriptor, CommandMap map)
        : base(descriptor)
      {
label_1:
        int num1 = -1397100223;
        while (true)
        {
          int num2 = -368830638;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1183566183 ^ -1067253105;
              continue;
            case 3:
              num1 = (int) num3 * 1772880868 ^ 1493624535;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        this._map = map;
      }

      public override PropertyDescriptorCollection GetProperties()
      {
        PropertyDescriptor[] propertyDescriptorArray = new PropertyDescriptor[this._map.Commands.Count];
        int num1 = 0;
        using (Dictionary<string, ICommand>.Enumerator enumerator = this._map.Commands.GetEnumerator())
        {
label_6:
          int num2 = enumerator.MoveNext() ? 1700484453 : (num2 = 699481476);
          while (true)
          {
            int num3 = 633100704;
            uint num4;
            KeyValuePair<string, ICommand> current;
            switch ((num4 = (uint) (num2 ^ num3)) % 5U)
            {
              case 0:
                num2 = 1700484453;
                continue;
              case 2:
                goto label_6;
              case 3:
                propertyDescriptorArray[num1++] = (PropertyDescriptor) new CommandMap.CommandPropertyDescriptor(current);
                num2 = (int) num4 * -1640877773 ^ 183051954;
                continue;
              case 4:
                current = enumerator.Current;
                num2 = 857490317;
                continue;
              default:
                goto label_8;
            }
          }
        }
label_8:
        PropertyDescriptorCollection descriptorCollection = CommandMap.CommandMapDescriptor.\u202B‏⁯⁫‭‬⁯‬‫⁭‪⁭⁫‏‍‎⁮⁯‬​⁯​‎​‎⁮⁯⁭‫​⁪⁬⁫⁭⁭⁮⁪⁫‌⁯‮(propertyDescriptorArray);
label_9:
        int num5 = 1634930486;
        while (true)
        {
          int num2 = 633100704;
          uint num3;
          switch ((num3 = (uint) (num5 ^ num2)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              num5 = (int) num3 * 825851265 ^ -993457559;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        return descriptorCollection;
      }

      static PropertyDescriptorCollection \u202B‏⁯⁫‭‬⁯‬‫⁭‪⁭⁫‏‍‎⁮⁯‬​⁯​‎​‎⁮⁯⁭‫​⁪⁬⁫⁭⁭⁮⁪⁫‌⁯‮([In] PropertyDescriptor[] obj0)
      {
        return new PropertyDescriptorCollection(obj0);
      }
    }

    private class CommandPropertyDescriptor : PropertyDescriptor
    {
      private ICommand _command;

      public override bool IsReadOnly
      {
        get
        {
label_1:
          int num1 = 1028536420;
          bool flag;
          while (true)
          {
            int num2 = 746038009;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 4U)
            {
              case 1:
                flag = true;
                num1 = (int) num3 * -1895896134 ^ -688967123;
                continue;
              case 2:
                num1 = (int) num3 * -2008746941 ^ 1403366487;
                continue;
              case 3:
                goto label_1;
              default:
                goto label_5;
            }
          }
label_5:
          return flag;
        }
      }

      public override Type ComponentType
      {
        get
        {
          throw CommandMap.CommandPropertyDescriptor.\u206F⁮‬⁯‏‍‌‮‮⁯‌⁪‎‍⁭⁪‌‮⁭‌‭‬⁪‭‪⁯⁭⁬‬⁭‎‪‬‭‬‏‍‏‮‌‮();
        }
      }

      public override Type PropertyType
      {
        get
        {
label_1:
          int num1 = -1126767895;
          Type type;
          while (true)
          {
            int num2 = -1375312915;
            uint num3;
            switch ((num3 = (uint) (num1 ^ num2)) % 3U)
            {
              case 0:
                goto label_1;
              case 2:
                type = CommandMap.CommandPropertyDescriptor.\u206D‪​‌⁪‍‪‏‮⁯‏⁫‫⁫‬‫⁫⁭‍⁭‪‍‌⁪⁫​‪‏‫⁯⁮‫‫‬⁬⁯⁪‬​⁯‮(__typeref (ICommand));
                num1 = (int) num3 * -10070571 ^ -78342399;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return type;
        }
      }

      public CommandPropertyDescriptor(KeyValuePair<string, ICommand> command)
        : base(command.Key, (Attribute[]) null)
      {
label_1:
        int num1 = -1868444608;
        while (true)
        {
          int num2 = -1853291732;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 1884554351 ^ -2002942178;
              continue;
            case 2:
              this._command = command.Value;
              num1 = (int) num3 * -1470049218 ^ -882873425;
              continue;
            case 3:
              num1 = (int) num3 * 1077079528 ^ 1704944981;
              continue;
            case 4:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }

      public override bool CanResetValue(object component)
      {
label_1:
        int num1 = 1990188617;
        bool flag;
        while (true)
        {
          int num2 = 494968652;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              flag = false;
              num1 = (int) num3 * -1276089765 ^ 1373210643;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return flag;
      }

      public override object GetValue(object component)
      {
        CommandMap commandMap = component as CommandMap;
label_1:
        int num1 = 708263844;
        object command;
        while (true)
        {
          int num2 = 479401157;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              command = (object) commandMap.Commands[CommandMap.CommandPropertyDescriptor.\u206A⁪⁯⁪‎‮⁪‬‏⁯⁮​‌⁭⁪‍⁯⁬‫‏​​‪⁬‫‪⁮⁫⁭⁫‪‭‏‎‮⁪⁭‌‪⁯‮((MemberDescriptor) this)];
              num1 = 1828054588;
              continue;
            case 1:
              int num4 = commandMap != null ? -1709345355 : (num4 = -1223683749);
              int num5 = (int) num3 * 982918786;
              num1 = num4 ^ num5;
              continue;
            case 2:
              goto label_5;
            case 3:
              num1 = (int) num3 * -1694175322 ^ -276521215;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_5:
        throw CommandMap.CommandPropertyDescriptor.\u200F‍‮⁬‬​‪‫⁭‫‪⁮⁫‫⁪⁮⁬‬‫‍‬⁯⁮‪⁬⁫‭⁮‏‮⁬‍‭‪‭‎⁮‫‫⁪‮(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(418819750U), \u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2188729277U));
label_7:
        return command;
      }

      public override void ResetValue(object component)
      {
        throw CommandMap.CommandPropertyDescriptor.\u206F⁮‬⁯‏‍‌‮‮⁯‌⁪‎‍⁭⁪‌‮⁭‌‭‬⁪‭‪⁯⁭⁬‬⁭‎‪‬‭‬‏‍‏‮‌‮();
      }

      public override void SetValue(object component, object value)
      {
        throw CommandMap.CommandPropertyDescriptor.\u206F⁮‬⁯‏‍‌‮‮⁯‌⁪‎‍⁭⁪‌‮⁭‌‭‬⁪‭‪⁯⁭⁬‬⁭‎‪‬‭‬‏‍‏‮‌‮();
      }

      public override bool ShouldSerializeValue(object component)
      {
        return false;
      }

      static NotImplementedException \u206F⁮‬⁯‏‍‌‮‮⁯‌⁪‎‍⁭⁪‌‮⁭‌‭‬⁪‭‪⁯⁭⁬‬⁭‎‪‬‭‬‏‍‏‮‌‮()
      {
        return new NotImplementedException();
      }

      static ArgumentException \u200F‍‮⁬‬​‪‫⁭‫‪⁮⁫‫⁪⁮⁬‬‫‍‬⁯⁮‪⁬⁫‭⁮‏‮⁬‍‭‪‭‎⁮‫‫⁪‮([In] string obj0, [In] string obj1)
      {
        return new ArgumentException(obj0, obj1);
      }

      static string \u206A⁪⁯⁪‎‮⁪‬‏⁯⁮​‌⁭⁪‍⁯⁬‫‏​​‪⁬‫‪⁮⁫⁭⁫‪‭‏‎‮⁪⁭‌‪⁯‮([In] MemberDescriptor obj0)
      {
        return obj0.Name;
      }

      static Type \u206D‪​‌⁪‍‪‏‮⁯‏⁫‫⁫‬‫⁫⁭‍⁭‪‍‌⁪⁫​‪‏‫⁯⁮‫‫‬⁬⁯⁪‬​⁯‮([In] RuntimeTypeHandle obj0)
      {
        return Type.GetTypeFromHandle(obj0);
      }
    }
  }
}
