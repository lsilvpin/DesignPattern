using System;
using System.Collections.Generic;

namespace DesignPattern.Data.Interfaces.Repositories
{
  /// <summary>
  /// Faz o CRUD no banco de dados
  /// </summary>
  /// <typeparam name="Entity">Entidade genérica sendo acessada</typeparam>
  public interface IRepository<Entity> : IDisposable
  {
    /// <summary>
    /// Cria um registro no bd
    /// </summary>
    /// <param name="entity">Entidade a ser registrada</param>
    /// <returns>Id do registro criado</returns>
    long Create(Entity entity);

    /// <summary>
    /// Cria uma lista de registros no banco
    /// </summary>
    /// <param name="entities">Lista de entidades a serem salvas</param>
    /// <returns>Quantidade de registros criados no banco</returns>
    long Create(IEnumerable<Entity> entities);

    /// <summary>
    /// Extrai uma entidade a partir de seu registro no banco
    /// </summary>
    /// <param name="Id">Id do registro</param>
    /// <returns>Entidade extraída do banco</returns>
    Entity Read(int entityId);

    /// <summary>
    /// Extrai todos os registros de uma certa entidade do banco
    /// </summary>
    /// <returns>Coleção com todas as entidades registradas no banco</returns>
    IEnumerable<Entity> ReadAll();

    /// <summary>
    /// Atualiza um registro no banco de dados
    /// </summary>
    /// <param name="entity">Entidade a ser atualizada</param>
    /// <returns>true se atualizada, false se não encontrada ou não modificada</returns>
    bool Update(Entity entity);

    /// <summary>
    /// Atualiza uma lista de registros no banco de dados
    /// </summary>
    /// <param name="entities">Coleção de entidades</param>
    /// <returns>true se atualizadas, false se alguma não for encontrada, ou não estiver modificada</returns>
    bool Update(IEnumerable<Entity> entities);

    /// <summary>
    /// Deleta um registro do banco de dados a partir do id
    /// </summary>
    /// <param name="entityId">Id do registro a ser apagado</param>
    /// <returns>true se apagado, false se não encontrado</returns>
    bool Delete(int entityId);

    /// <summary>
    /// Deleta um registro do banco de dados a partir da entidade
    /// </summary>
    /// <param name="entity">Entidade cujo registro deve ser apagado</param>
    /// <returns>true se apagado, false se não encontrado</returns>
    bool Delete(Entity entity);

    /// <summary>
    /// Deleta uma coleção de registros do banco de dados
    /// </summary>
    /// <param name="entities">Coleção de entidades</param>
    /// <returns>true se apagados, false se algum não for encontrado</returns>
    bool Delete(IEnumerable<Entity> entities);
  }
}
