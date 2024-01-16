﻿using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryModelDal : InMemoryEntityRepositoryBase<Model, int>, IModelDal
    {
        //ayrı yazılacak bir kod varsa buraya yazılabilir
        protected override int generateId()
        {
            throw new NotImplementedException();
        }
    }
}