﻿using AutoMapper;
using PracticumProject.common.DTO;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services.Services
{
    public class ChildUserService:IChildUserService
    {
        private readonly IChildUserRepository _childUserRepository;
        private readonly IMapper _mapper;

        public ChildUserService(IChildUserRepository childUserRepository, IMapper mapper)
        {
            _childUserRepository = childUserRepository;
            _mapper = mapper;
        }
        public async Task<ChildUserDTO> AddAsync(ChildUserDTO childUserDTO)
        {
            return _mapper.Map<ChildUserDTO>(await _childUserRepository.AddAsync(_mapper.Map<ChildUser>(childUserDTO)));
        }

        public async Task DeleteAsync(int id)
        {
            await _childUserRepository.DeleteAsync(id);
        }

        public async Task<List<ChildUserDTO>> GetAllAsync()
        {
          return _mapper.Map<List<ChildUserDTO>>(await _childUserRepository.GetAllAsync());
        }

        public async Task<ChildUserDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildUserDTO>(await _childUserRepository.GetByIdAsync(id));
        }

        public async Task<ChildUserDTO> UpdateAsync(ChildUserDTO childUserDTO)
        {
            return _mapper.Map<ChildUserDTO>(await _childUserRepository.UpdateAsync(_mapper.Map<ChildUser>(childUserDTO)));
        }
    }
}
