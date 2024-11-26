'use client';

import React, {useCallback, useEffect, useState} from 'react';
import {iconUrl, imageUrl} from "@/utils/constants";
import Stat from "@/components/info/Stat";
import restaurantService from "@/services/restaurant.service";
import {Restaurant} from "@/models/Restaurant";
import {useParams} from "next/navigation";

const Info = () => {
  const [data, setData] = useState<Restaurant>();

  const params = useParams();
  const { id } = params as { id: string };

  const fetchRestaurant = useCallback(async (id: string) => {
    const response = await restaurantService.getRestaurant(id);
    setData(response.data);
  }, []);

  useEffect(() => {
    if (!id) return
    fetchRestaurant(id);
  }, [fetchRestaurant, id]);

  return (
    <div className='px-8 mt-10'>
      <div>
        <div className='flex'>
          <h1>Biblioteka resto•bar</h1>
          <div className='bg-[#8A613599] rounded-full p-4 ml-6'>
            <img src={`${iconUrl}/bookmark.svg`} alt="bookmark"/>
          </div>
        </div>
        <div className='mt-10 flex gap-11'>
          <img className='' src={`${imageUrl}/info/restaurant.png`} alt="restaurant"/>
          <div className='flex flex-col'>
            <Stat icon='point' content={data?.address} styles='mb-10'/>
            <Stat icon='clock' content='10:00 — 22:00' styles='mb-10'/>
            <Stat icon='coin' content={`${data?.lowerPrice}-${data?.upperPrice} ₴`} styles='mb-10'/>
            <Stat icon='cutlery' content='Italic food' styles='mb-10'/>
            <Stat icon='telephone' content={data?.phoneNumber} styles='mb-10'/>
            <Stat icon='menu' content='Menu' styles='mb-10'/>
            <Stat icon='5' content={<img src={`${iconUrl}/hearts.svg`} alt="rating"/>}/>
          </div>
        </div>
      </div>
      <div className='mt-11'>
        <h1>About</h1>
        <hr className='mb-6'/>
        <span className='text-4xl font-medium'>
          {data?.aboutText}
        </span>
      </div>
      <div className='mt-11'>
        <h1>Client`s review</h1>
        <hr className='mb-7'/>
        <div className='flex   gap-8'>
          <div className='bg-[#5D462D] rounded-full py-6 px-5 shrink-0 h-fit'>
            <img src={`${iconUrl}/cake.svg`} alt="cake"/>
          </div>
          <div className='flex flex-col gap-3'>
            <span className='text-4xl font-medium'>Sweet Cake</span>
            <img  className='w-fit' src={`${iconUrl}/hearts.svg`} alt="rating"/>
            <span className='text-2xl'>
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi eget faucibus tortor. Vivamus blandit eros
              in enim mollis, vel lobortis neque eleifend. Sed a consectetur tellus, ut sodales nibh. Lorem ipsum dolor
              sit amet, consectetur adipiscing elit. Nullam ut nulla urna. Aliquam dolor nisl, convallis sit amet diam
              ut, tempor euismod massa. Etiam commodo placerat libero, ut placerat elit sagittis vel.
            </span>
          </div>
        </div>
        <div className='flex justify-end mt-5 pr-16 mb-14'>
          <button className='bg-[#F0BB81] px-8 py-1 rounded-[20px] text-[32px] font-bold text-[#5D462D]'>
            Add new review
          </button>
        </div>
      </div>
    </div>
  );
};

export default Info;