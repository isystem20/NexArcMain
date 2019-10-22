using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nextoolkit
{
    class Program
    {
        static void Main(string[] args)
        {

            var run = "Y";


            do
            {
                Console.Clear();
                Console.WriteLine("This console program is intended to generate ABP Modules.");

                //Get Project Prefix Name
                Console.Write("\nProject Prefix : ");
                var project = Console.ReadLine();

                //Initiate Application Folder
                var appPath = "";
                if (project != "")
                {
                    appPath = $"src\\{project}.Application\\";
                }
                else
                {
                    appPath = $"src\\Application\\";
                }


                //Get Entity Name or Folder
                var entity = "";
                do
                {
                    Console.Write("\nEnter Entity Name:");
                    entity = Console.ReadLine();
                } while (entity == "");

                char[] delim = { '/', '.','\\' };

                var n = entity.Split(delim);

                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                appPath = currentDirectory + appPath;

                var newEntity = "";
                if (n.Length > 1)
                {
                    var e = n.Length - 1;

                    for (int i = 0; i < n.Length - 1; i++)
                    {
                        //Console.WriteLine($"\n{n[i]}");
                        appPath = appPath + n[i] + '\\';
                    }
                    newEntity = n[e];

                }
                else
                {
                    newEntity = entity;
                }

                //App Service Path
                appPath = appPath + newEntity + "\\";

                //Dto App
                var appPathDto = appPath + "Dto\\";

                //Make the directory
                if (!System.IO.Directory.Exists(appPath))
                {
                    System.IO.Directory.CreateDirectory(appPath);
                }

                //Make the directory
                if (!System.IO.Directory.Exists(appPathDto))
                {
                    System.IO.Directory.CreateDirectory(appPathDto);
                }

                var auth = "Y";
                Console.Write("\nAdd Authentication to this module? Y/N (Y)");
                auth = Console.ReadLine().ToUpper();


                var prefixPermission = "";
                if (auth == "Y")
                {
                    Console.Write("\nPermission Prefix:");
                    prefixPermission = Console.ReadLine() + ".";

                }

                string[] allFiles = Directory.GetFiles(currentDirectory, newEntity + ".cs", SearchOption.AllDirectories);

                string[] forAddition = { };
                string namespaceString = "";
                var findVars = "{ get; set; }";
                var findNameSpace = "namespace";

                var entityModel = "";
                if (allFiles.Length > 0)
                {
                    entityModel = allFiles[0];

                    string[] lines = File.ReadAllLines(entityModel);

                    foreach (string line in lines)
                    {
                        if (line.Contains(findVars))
                        {
                            if (!line.Contains("ICollection"))
                            {
                                Array.Resize(ref forAddition, forAddition.Length + 1);
                                forAddition[forAddition.Length - 1] = line;
                            }

                        }

                        if (line.Contains(findNameSpace))
                        {
                            namespaceString = line.Replace(findNameSpace + " ","");
                        }

                    }

                    Console.WriteLine("\nEntity Found:" + entityModel);

                }



                //Optional References
                Console.WriteLine("\nAdditional Optional References (Enum, other Entites, Etc) separated by comma (,):");

                var optionalNAmeSpaces = new List<string> { };
                string[] newOptNameSpaces = { };
                var opt = Console.ReadLine();

                if (opt != "")
                {
                    optionalNAmeSpaces = opt.Split(',').ToList();
                    var searched = Directory.GetFiles(currentDirectory, "*.cs", SearchOption.AllDirectories);
                    var refIndex = searched.Where(f => optionalNAmeSpaces.IndexOf(Path.GetFileName(f)) >= 0).ToArray();

                    foreach (var item in refIndex)
                    {
                        Console.WriteLine($"refIndex: {item}");
                    }



                    if (refIndex.Length > 0)
                    {
                        foreach (var file in refIndex)
                        {
                            Console.WriteLine($"Found: {file}");
                            string[] lines = File.ReadAllLines(file);

                            foreach (var line in lines)
                            {
                                if (line.Contains(findNameSpace))
                                {
                                    Console.WriteLine($"Added: {line}");
                                    Array.Resize(ref newOptNameSpaces, newOptNameSpaces.Length + 1);
                                    newOptNameSpaces[newOptNameSpaces.Length - 1] = line.Replace(findNameSpace + " ", "");
                                }
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Optional References not found: {opt}");
                    }

                }



                #region Create App Service
                //Make AppService
                var pathString = Path.Combine(appPath, newEntity + "AppService.cs");
                using (StreamWriter file = new StreamWriter(pathString, true))
                {
                    //Add the Entity refence
                    if (namespaceString != "")
                    {
                        file.WriteLine("using " + namespaceString + ";");
                    }
                    file.WriteLine("using Abp.Application.Services;");
                    file.WriteLine("using Abp.Application.Services.Dto;");
                    file.WriteLine("using Abp.Authorization;");
                    file.WriteLine("using " + project + ".Authorization;");
                    file.WriteLine("using Abp.Collections.Extensions;");
                    file.WriteLine("using Abp.Domain.Repositories;");
                    file.WriteLine("using Abp.Extensions;");
                    file.WriteLine("using " + project + ".Nex" + newEntity + ".Dto;");
                    file.WriteLine("using System;");
                    file.WriteLine("using System.Collections.Generic;");
                    file.WriteLine("using System.Linq;");
                    file.WriteLine("using System.Text;");
                    file.WriteLine("using System.Threading.Tasks;");
                    file.WriteLine("using Abp.Linq.Extensions;");
                    file.WriteLine("");
                    file.WriteLine("namespace " + project + ".Nex" + newEntity);
                    file.WriteLine("{");

                    //Apply Authentication if desired
                    if (namespaceString != "")
                    {
                        file.WriteLine("\t//[AbpAuthorize(\"" + prefixPermission + newEntity + "\")]");
                    }

                    file.WriteLine("\tpublic class " + newEntity + "AppService : AsyncCrudAppService<" + newEntity + ", " + newEntity + "Dto, int, Paged" + newEntity + "ResultRequestDto, Create" + newEntity + "Dto, Update" + newEntity + "Dto>, I" + newEntity + "AppService");
                    file.WriteLine("\t{");
                    file.WriteLine("");
                    file.WriteLine("\t\tprivate readonly IRepository<" + newEntity + "> _r" + newEntity + ";");
                    file.WriteLine("");
                    file.WriteLine("\t\tpublic " + newEntity + "AppService(IRepository<" + newEntity + "> r" + newEntity + ") : base(r" + newEntity + ")");
                    file.WriteLine("\t\t{");
                    file.WriteLine("\t\t\t_r" + newEntity + " = r" + newEntity + ";");
                    file.WriteLine("\t\t}");
                    file.WriteLine("");
                    //Apply Authentication for READ
                    if (namespaceString != "")
                    {
                        file.WriteLine("\t\t[AbpAuthorize(\"" + prefixPermission + newEntity + ".Read\")]");
                    }
                    file.WriteLine("\t\tprotected override IQueryable<" + newEntity + "> CreateFilteredQuery(Paged" + newEntity + "ResultRequestDto input)");
                    file.WriteLine("\t\t{");
                    file.WriteLine("\t\t\treturn Repository.GetAll()");
                    file.WriteLine("\t\t\t\t.WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Keyword))");
                    file.WriteLine("\t\t\t\t.WhereIf(input.Status.HasValue, x => x.Status == input.Status);");
                    file.WriteLine("\t\t}");

                    file.WriteLine("");
                    //Apply Authentication for CREATE
                    if (namespaceString != "")
                    {
                        file.WriteLine("\t\t[AbpAuthorize(\"" + prefixPermission + newEntity + ".Create\")]");
                    }
                    file.WriteLine("\t\tpublic override async Task<" + newEntity + "Dto> Create(Create" + newEntity + "Dto input)");
                    file.WriteLine("\t\t{");
                    file.WriteLine("\t\t\tvar entity = MapToEntity(input);");
                    file.WriteLine("");
                    file.WriteLine("\t\t\tawait Repository.InsertAsync(entity);");
                    file.WriteLine("\t\t\tawait CurrentUnitOfWork.SaveChangesAsync();");
                    file.WriteLine("");
                    file.WriteLine("\t\t\treturn MapToEntityDto(entity);");
                    file.WriteLine("\t\t}");
                    file.WriteLine("");

                    //Apply Authentication for UPDATE
                    if (namespaceString != "")
                    {
                        file.WriteLine("\t\t[AbpAuthorize(\"" + prefixPermission + newEntity + ".Update\")]");
                    }
                    file.WriteLine("\t\tpublic override async Task<" + newEntity + "Dto> Update(Update" + newEntity + "Dto input)");
                    file.WriteLine("\t\t{");
                    file.WriteLine("\t\t\tvar entity = await GetEntityByIdAsync(input.Id);");
                    file.WriteLine("");
                    file.WriteLine("\t\t\tMapToEntity(input, entity);");
                    file.WriteLine("\t\t\tawait CurrentUnitOfWork.SaveChangesAsync();");
                    file.WriteLine("");
                    file.WriteLine("\t\t\treturn MapToEntityDto(entity);");
                    file.WriteLine("\t\t}");

                    //Apply Authentication for DELETE
                    if (namespaceString != "")
                    {
                        file.WriteLine("\t\t[AbpAuthorize(\"" + prefixPermission + newEntity + ".Delete\")]");
                    }
                    file.WriteLine("\t\tpublic override async Task Delete(EntityDto<int> input)");
                    file.WriteLine("\t\t{");
                    file.WriteLine("\t\t\tvar record = await _r" + newEntity + ".FirstOrDefaultAsync(input.Id);");
                    file.WriteLine("");
                    file.WriteLine("\t\t\tawait _r" + newEntity + ".DeleteAsync(record);");
                    file.WriteLine("\t\t}");

                    //Apply Authentication for READ SINGLE
                    if (namespaceString != "")
                    {
                        file.WriteLine("\t\t[AbpAuthorize(\"" + prefixPermission + newEntity + ".Read\")]");
                    }
                    file.WriteLine("\t\tprotected override async Task<" + newEntity + "> GetEntityByIdAsync(int id)");
                    file.WriteLine("\t\t{");
                    file.WriteLine("\t\t\treturn await Repository.GetAsync(id);");
                    file.WriteLine("\t\t}");

                    file.WriteLine("");
                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
                Console.Write($"\nFile Generated:\n{newEntity}AppService.cs");
                #endregion

                #region App Service Interface
                //Make Update EntityDto
                var aidtoString = Path.Combine(appPath, "I" + newEntity + "AppService.cs");
                using (StreamWriter file = new StreamWriter(aidtoString, true))
                {
                    file.WriteLine("using Abp.Application.Services;");
                    file.WriteLine("using " + project + ".Nex" + newEntity + ".Dto;");
                    file.WriteLine("");
                    file.WriteLine("namespace " + project + ".Nex" + newEntity + "");
                    file.WriteLine("{");
                    file.WriteLine("\tpublic interface I" + newEntity + "AppService : IAsyncCrudAppService<" + newEntity + "Dto, int, Paged" + newEntity + "ResultRequestDto, Create" + newEntity + "Dto, Update" + newEntity + "Dto>");
                    file.WriteLine("\t{");
                    file.WriteLine("");
                    file.WriteLine("\t\t//Put something if applicable");
                    file.WriteLine("");
                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
                Console.Write($"\nI" + newEntity + "AppService.cs");
                #endregion


                #region EntityDto
                //Make AppService
                var dtoString = Path.Combine(appPathDto, newEntity + "Dto.cs");
                using (StreamWriter file = new StreamWriter(dtoString, true))
                {
                    //Add the Entity refence
                    if (namespaceString != "")
                    {
                        file.WriteLine("using " + namespaceString + ";");
                    }
                    foreach (var ns in newOptNameSpaces)
                    {
                        file.WriteLine("using " + ns + ";");
                    }
                    file.WriteLine("using Abp.Application.Services;");
                    file.WriteLine("using Abp.AutoMapper;");
                    file.WriteLine("using Abp.Application.Services.Dto;");
                    file.WriteLine("using System;");
                    file.WriteLine("");
                    file.WriteLine("namespace " + project + ".Nex" + newEntity + ".Dto");
                    file.WriteLine("{");
                    file.WriteLine("\t[AutoMapFrom(typeof(" + newEntity + "))]");
                    file.WriteLine("\tpublic class " + newEntity + "Dto : EntityDto<int>");
                    file.WriteLine("\t{");
                    file.WriteLine("");
                    foreach (var l in forAddition)
                    {
                        //Console.WriteLine($"\nAdded Line: {l}");
                        file.WriteLine(l);
                    }
                    file.WriteLine("");
                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
                Console.Write($"\n{newEntity}Dto.cs");
                #endregion

                #region Create EntityDto
                //Make Create Entity Dto
                var cdtoString = Path.Combine(appPathDto, "Create" + newEntity + "Dto.cs");
                using (StreamWriter file = new StreamWriter(cdtoString, true))
                {
                    //Add the Entity refence
                    if (namespaceString != "")
                    {
                        file.WriteLine("using " + namespaceString + ";");
                    }
                    foreach (var ns in newOptNameSpaces)
                    {
                        file.WriteLine("using " + ns + ";");
                    }
                    file.WriteLine("using Abp.AutoMapper;");
                    file.WriteLine("using System.ComponentModel.DataAnnotations;");
                    file.WriteLine("using System;");
                    file.WriteLine("");
                    file.WriteLine("namespace " + project + ".Nex" + newEntity + ".Dto");
                    file.WriteLine("{");
                    file.WriteLine("\t[AutoMapTo(typeof(" + newEntity + "))]");
                    file.WriteLine("\tpublic class Create" + newEntity + "Dto");
                    file.WriteLine("\t{");
                    file.WriteLine("");
                    foreach (var l in forAddition)
                    {
                        file.WriteLine("\t\t[Required]");
                        file.WriteLine(l);
                    }
                    file.WriteLine("");
                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
                Console.Write($"\nCreate{newEntity}Dto.cs");
                #endregion

                #region Update EntityDto
                //Make Update EntityDto
                var udtoString = Path.Combine(appPathDto, "Update" + newEntity + "Dto.cs");
                using (StreamWriter file = new StreamWriter(udtoString, true))
                {
                    //Add the Entity refence
                    if (namespaceString != "")
                    {
                        file.WriteLine("using " + namespaceString + ";");
                    }
                    file.WriteLine("using Abp.Application.Services.Dto;");
                    file.WriteLine("using System.ComponentModel.DataAnnotations;");
                    file.WriteLine("using System;");
                    file.WriteLine("using Abp.AutoMapper;");
                    file.WriteLine("");
                    file.WriteLine("namespace " + project + ".Nex" + newEntity + ".Dto");
                    file.WriteLine("{");
                    file.WriteLine("\t[AutoMapTo(typeof(" + newEntity + "))]");
                    file.WriteLine("\tpublic class Update" + newEntity + "Dto : Create" + newEntity + "Dto, IEntityDto");
                    file.WriteLine("\t{");
                    file.WriteLine("");
                    file.WriteLine("\t\tpublic int Id { get; set; }");
                    file.WriteLine("");
                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
                Console.Write($"\nUpdate{newEntity}Dto.cs");
                #endregion

                #region Paged Entity Dto
                //Make Update EntityDto
                var pdtoString = Path.Combine(appPathDto, "Paged" + newEntity + "ResultRequestDto.cs");
                using (StreamWriter file = new StreamWriter(pdtoString, true))
                {
                    foreach (var ns in newOptNameSpaces)
                    {
                        file.WriteLine("using " + ns + ";");
                    }
                    file.WriteLine("using Abp.Application.Services.Dto;");
                    file.WriteLine("");
                    file.WriteLine("namespace " + project + ".Nex" + newEntity + ".Dto");
                    file.WriteLine("{");
                    file.WriteLine("\tpublic class Paged" + newEntity + "ResultRequestDto : PagedResultRequestDto");
                    file.WriteLine("\t{");
                    file.WriteLine("");
                    file.WriteLine("\t\tpublic string Keyword { get; set; }");
                    file.WriteLine("\t\tpublic RecordStatus? Status { get; set; }");
                    file.WriteLine("");
                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
                Console.Write($"\nPaged{newEntity}ResultRequestDto.cs");
                #endregion



                //Register Permission Names
                //Apply Authentication if desired
                if (namespaceString != "")
                {
                    string[] permissionProvider = Directory.GetFiles(currentDirectory, project + "AuthorizationProvider.cs", SearchOption.AllDirectories);

                    if (permissionProvider.Count() > 0)
                    {
                        Console.Write("Auth Provider Found:" + permissionProvider[0]);
                        string[] lines = File.ReadAllLines(permissionProvider[0]);
                        var newContent = new List<string> { };
                        int lastline = 0;

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i].Contains("CreatePermission") || lines[i].Contains("CreateChildPermission"))
                            {
                                lastline = i;
                            }
                        }

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i == lastline)
                            {
                                newContent.Add(lines[i]);
                                newContent.Add("");
                                newContent.Add("\t\t\tcontext.CreatePermission(\"" + prefixPermission + newEntity + "\",L(\"" + prefixPermission + " " + newEntity + "\"))");
                                newContent.Add("\t\t\t\t.CreateChildPermission(\"" + prefixPermission + newEntity + ".Create\",L(\"" + prefixPermission + " Create " + newEntity + "\"))");
                                newContent.Add("\t\t\t\t.CreateChildPermission(\"" + prefixPermission + newEntity + ".Read\",L(\"" + prefixPermission + " Read " + newEntity + "\"))");
                                newContent.Add("\t\t\t\t.CreateChildPermission(\"" + prefixPermission + newEntity + ".Update\",L(\"" + prefixPermission + " Update " + newEntity + "\"))");
                                newContent.Add("\t\t\t\t.CreateChildPermission(\"" + prefixPermission + newEntity + ".Delete\",L(\"" + prefixPermission + " Delete " + newEntity + "\"));");
                            }
                            else
                            {
                                newContent.Add(lines[i]);
                            }
                        }

                        File.WriteAllText(permissionProvider[0], String.Empty);

                        using (StreamWriter file = new StreamWriter(permissionProvider[0], true))
                        {
                            foreach (var line in newContent)
                            {
                                file.WriteLine(line);
                                //Console.WriteLine(line);
                            }    

                        }

                       


                    }


                    //file.WriteLine("\t[AbpAuthorize(PermissionNames.Pages_" + newEntity + "CRUD)]");
                }



                Console.WriteLine("\n\n\nRun again? Y/N");
                run = Console.ReadLine().ToUpper();

            } while (run == "Y");


            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


        }
    }
}
