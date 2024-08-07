using agora.domain;

namespace agora.article.domain.entities;

public class Category : IValidatedEntity
{
    public int Id { get; }
    public string Name { get; private set; }

    public void ThrowsIfInvalidData(bool creatingEntity = false)
    {
        if(Id < 0 || Id == default(int))
            throw new Exception(ExceptionMessages.InvalidProperty(nameof(Id), Id.ToString()));

        if(string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
            throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Name)));
    }

  public Category(string name) => Name = name;
}
