using System.Reflection;

var tipi = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
{
    ["bool"] = typeof(bool),
    ["byte"] = typeof(byte),
    ["sbyte"] = typeof(sbyte),
    ["short"] = typeof(short),
    ["ushort"] = typeof(ushort),
    ["int"] = typeof(int),
    ["uint"] = typeof(uint),
    ["long"] = typeof(long),
    ["ulong"] = typeof(ulong),
    ["char"] = typeof(char),
    ["float"] = typeof(float),
    ["double"] = typeof(double),
    ["decimal"] = typeof(decimal),
    ["nint"] = typeof(IntPtr),
    ["nuint"] = typeof(UIntPtr),
    ["string"] = typeof(string),
    ["object"] = typeof(object),
};

if (args.Length == 0)
{
    StampaIndice();
    return;
}

string tipoRichiesto = args[0];

if (!tipi.TryGetValue(tipoRichiesto, out Type? tipo))
{
    Console.WriteLine($"Errore: tipo '{tipoRichiesto}' non riconosciuto.");
    Console.WriteLine();
    StampaIndice();
    return;
}

AnalizzaTipo(tipoRichiesto, tipo);

void StampaIndice()
{
    Console.WriteLine("Tipi disponibili:");
    foreach (string nome in tipi.Keys.OrderBy(x => x))
    {
        Console.WriteLine($"- {nome}");
    }

    Console.WriteLine();
    Console.WriteLine("Uso:");
    Console.WriteLine("  dotnet run -- <tipo>");
    Console.WriteLine();
    Console.WriteLine("Esempi:");
    Console.WriteLine("  dotnet run -- int");
    Console.WriteLine("  dotnet run -- string");
    Console.WriteLine("  dotnet run -- decimal");
    Console.WriteLine("  dotnet run -- bool");
}

void AnalizzaTipo(string alias, Type tipo)
{
    Console.WriteLine($"Alias C#      : {alias}");
    Console.WriteLine($"Tipo .NET     : {tipo.FullName}");
    Console.WriteLine($"Categoria CLR : {CategoriaClr(tipo)}");
    Console.WriteLine($"Semantica     : {(tipo.IsValueType ? "value type" : "reference type")}");
    Console.WriteLine($"Dimensione    : {Dimensione(tipo)}");
    Console.WriteLine($"TypeCode      : {Type.GetTypeCode(tipo)}");
    Console.WriteLine($"Range reale   : {RangeReale(tipo)}");
    Console.WriteLine();

    StampaSezione(
        "Campi statici pubblici",
        tipo.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
            .Select(DescriviCampo)
            .OrderBy(x => x)
    );

    StampaSezione(
        "Proprietà statiche pubbliche",
        tipo.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
            .Where(p => (p.GetMethod?.IsPublic ?? false) || (p.SetMethod?.IsPublic ?? false))
            .Select(p => $"{NomeCompatto(p.PropertyType)} {p.Name}")
            .OrderBy(x => x)
    );

    StampaSezione(
        "Metodi statici pubblici",
        tipo.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName)
            .Select(FirmaMetodo)
            .Distinct()
            .OrderBy(x => x)
    );

    StampaSezione(
        "Metodi di istanza pubblici",
        tipo.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
            .Where(m => !m.IsSpecialName)
            .Select(FirmaMetodo)
            .Distinct()
            .OrderBy(x => x)
    );
}

void StampaSezione(string titolo, IEnumerable<string> elementi)
{
    var lista = elementi.ToList();

    Console.WriteLine($"[{titolo}]");
    if (lista.Count == 0)
    {
        Console.WriteLine("  (nessuno)");
    }
    else
    {
        foreach (var item in lista)
        {
            Console.WriteLine($"  - {item}");
        }
    }

    Console.WriteLine();
}

string CategoriaClr(Type tipo)
{
    if (tipo.IsEnum) return "enum";
    if (tipo.IsInterface) return "interface";
    if (typeof(Delegate).IsAssignableFrom(tipo)) return "delegate";
    if (tipo.IsValueType) return "struct";
    if (tipo.IsClass) return "class";
    return "altro";
}

string Dimensione(Type tipo)
{
    if (tipo == typeof(bool))   return "1 byte (dimensione del valore)";
    if (tipo == typeof(byte))   return "1 byte";
    if (tipo == typeof(sbyte))  return "1 byte";
    if (tipo == typeof(short))  return "2 byte";
    if (tipo == typeof(ushort)) return "2 byte";
    if (tipo == typeof(int))    return "4 byte";
    if (tipo == typeof(uint))   return "4 byte";
    if (tipo == typeof(long))   return "8 byte";
    if (tipo == typeof(ulong))  return "8 byte";
    if (tipo == typeof(char))   return "2 byte (UTF-16 code unit)";
    if (tipo == typeof(float))  return "4 byte";
    if (tipo == typeof(double)) return "8 byte";
    if (tipo == typeof(decimal))return "16 byte";
    if (tipo == typeof(IntPtr)) return $"{IntPtr.Size} byte (dipende dalla piattaforma)";
    if (tipo == typeof(UIntPtr))return $"{UIntPtr.Size} byte (dipende dalla piattaforma)";

    if (!tipo.IsValueType)
        return $"{IntPtr.Size} byte per il riferimento; oggetto reale a dimensione variabile";

    return "dimensione non mostrata";
}

string RangeReale(Type tipo)
{
    if (tipo == typeof(bool))   return "false / true";
    if (tipo == typeof(byte))   return $"{byte.MinValue} .. {byte.MaxValue}";
    if (tipo == typeof(sbyte))  return $"{sbyte.MinValue} .. {sbyte.MaxValue}";
    if (tipo == typeof(short))  return $"{short.MinValue} .. {short.MaxValue}";
    if (tipo == typeof(ushort)) return $"{ushort.MinValue} .. {ushort.MaxValue}";
    if (tipo == typeof(int))    return $"{int.MinValue} .. {int.MaxValue}";
    if (tipo == typeof(uint))   return $"{uint.MinValue} .. {uint.MaxValue}";
    if (tipo == typeof(long))   return $"{long.MinValue} .. {long.MaxValue}";
    if (tipo == typeof(ulong))  return $"{ulong.MinValue} .. {ulong.MaxValue}";
    if (tipo == typeof(char))   return $"U+{(int)char.MinValue:X4} .. U+{(int)char.MaxValue:X4} (0 .. 65535)";
    if (tipo == typeof(float))  return $"{float.MinValue:E} .. {float.MaxValue:E}";
    if (tipo == typeof(double)) return $"{double.MinValue:E} .. {double.MaxValue:E}";
    if (tipo == typeof(decimal))return $"{decimal.MinValue} .. {decimal.MaxValue}";
    if (tipo == typeof(IntPtr))
    {
        return IntPtr.Size == 8
            ? $"{long.MinValue} .. {long.MaxValue}"
            : $"{int.MinValue} .. {int.MaxValue}";
    }
    if (tipo == typeof(UIntPtr))
    {
        return UIntPtr.Size == 8
            ? $"{ulong.MinValue} .. {ulong.MaxValue}"
            : $"{uint.MinValue} .. {uint.MaxValue}";
    }

    if (tipo == typeof(string) || tipo == typeof(object))
        return "non ha range numerico";

    return "non disponibile";
}

string DescriviCampo(FieldInfo campo)
{
    string descrizioneBase = $"{NomeCompatto(campo.FieldType)} {campo.Name}";

    try
    {
        object? valore = campo.GetValue(null);
        return $"{descrizioneBase} = {FormattaValore(valore)}";
    }
    catch
    {
        return descrizioneBase;
    }
}

string FirmaMetodo(MethodInfo metodo)
{
    string parametri = string.Join(", ",
        metodo.GetParameters().Select(p =>
        {
            Type tipoParametro = p.ParameterType.IsByRef
                ? p.ParameterType.GetElementType()!
                : p.ParameterType;

            string prefisso = p.IsOut ? "out " : "";
            return $"{prefisso}{NomeCompatto(tipoParametro)} {p.Name}";
        }));

    return $"{NomeCompatto(metodo.ReturnType)} {metodo.Name}({parametri})";
}

string NomeCompatto(Type tipo)
{
    if (tipo.IsByRef)
        return NomeCompatto(tipo.GetElementType()!);

    if (tipo == typeof(void)) return "void";
    if (tipo == typeof(bool)) return "bool";
    if (tipo == typeof(byte)) return "byte";
    if (tipo == typeof(sbyte)) return "sbyte";
    if (tipo == typeof(short)) return "short";
    if (tipo == typeof(ushort)) return "ushort";
    if (tipo == typeof(int)) return "int";
    if (tipo == typeof(uint)) return "uint";
    if (tipo == typeof(long)) return "long";
    if (tipo == typeof(ulong)) return "ulong";
    if (tipo == typeof(char)) return "char";
    if (tipo == typeof(float)) return "float";
    if (tipo == typeof(double)) return "double";
    if (tipo == typeof(decimal)) return "decimal";
    if (tipo == typeof(string)) return "string";
    if (tipo == typeof(object)) return "object";
    if (tipo == typeof(IntPtr)) return "nint";
    if (tipo == typeof(UIntPtr)) return "nuint";

    if (tipo.IsArray)
        return $"{NomeCompatto(tipo.GetElementType()!)}[]";

    if (tipo.IsGenericType)
    {
        string nomeBase = tipo.Name;
        int tick = nomeBase.IndexOf('`');
        if (tick >= 0)
            nomeBase = nomeBase[..tick];

        string argsGenerici = string.Join(", ", tipo.GetGenericArguments().Select(NomeCompatto));
        return $"{nomeBase}<{argsGenerici}>";
    }

    return tipo.Name;
}

string FormattaValore(object? valore)
{
    if (valore is null)
        return "null";

    if (valore is string s)
        return $"\"{s}\"";

    if (valore is char c)
        return $"'{c}' (U+{(int)c:X4})";

    if (valore is bool b)
        return b ? "true" : "false";

    return valore.ToString() ?? "(valore non stampabile)";
}
