import {imageUrl} from "@/utils/constants";
import InfoItem from "@/components/InfoItem";
import React from "react";

export default function Home() {
  const data = [
    {
      title: 'Register or login',
      description: 'fvfkssvkpokvspkopv sflvsvofsvk mvsvsvmf mcs skcmkdmsk ckmmcdk kcsmkcsd j jdcjds mksmc',
      enableButton: true,
      buttonText: 'Register'
    },
    {
      title: 'Choose preferences',
      description: 'Quick way to choose where you must go today. Delicious and beautiful places await you',
      enableButton: false,
    },
    {
      title: 'Like or pass',
      description: 'Quick way to choose where you must go today. Delicious and beautiful places await you',
      enableButton: false,
    },
    {
      title: 'Don`t like swipe?',
      description: 'Quick way to choose where you must go today. Delicious and beautiful places await you',
      enableButton: true,
      buttonText: 'Search'
    }
  ]

  return (
    <main>
      <div className='flex h-[582px] px-6'>
        <img className='absolute w-full top-0 left-0 right-0 h-[582px] ' src={`${imageUrl}/homepage/home-background.png`} alt="coffee"/>
        <div className='z-10 flex justify-between text-[40px] w-full mt-[80px] font-medium'>
          <h2 className='text-left max-w-[521px]'>Find the best place to hangout with friends or celebrate important event</h2>
          <h2 className='text-right max-w-[500px]'>Quick way to choose where you must go today. Delicious and beautiful places await you</h2>
        </div>
      </div>
      <div className='pt-[55px] px-6'>
        <h2 className='font-bold'>What you need?</h2>
        <hr/>
        <div className='grid gap-2 mt-6 grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4'>
          {data.map((item, index) => (
            <InfoItem title={item.title} description={item.description} buttonText={item.buttonText} />
          ))}
        </div>
      </div>
      <div className='pt-[80px] pb-[44px] pl-6 pr-6 lg:pr-0'>
        <div className='flex relative'>
          <div className='flex-[3]'>
            <h2 className='font-bold mb-[19px]'>Want to see place that you liked earlier?</h2>
            <p className='text-[1.875rem] leading-10'>
              Lorem ipsum dolor sit amet, consectetur adipisicing elit. Hic, itaque saepe? Ab aliquam dicta, dolores ea enim eveniet, exercitationem facilis fugiat impedit iusto nesciunt quibusdam quis rem sint ut vel. Alias asperiores assumenda aut blanditiis consequatur consequuntur distinctio doloribus harum ipsa maxime, porro quidem ratione repudiandae ullam ut, vero, vitae? Animi doloremque ducimus et maxime nobis sed vel? Quod, ratione? Deserunt dolore eaque, earum eveniet facere in nobis praesentium quas, qui recusandae rerum sint ullam. A aliquam, architecto ex expedita in, laboriosam necessitatibus officia optio quibusdam repellat saepe sed sunt. Aliquam aspernatur autem commodi
            </p>
            <button className='mt-[41px] bg-[#5D462D] py-2 px-9 rounded-[40px] font-bold text-[2rem] w-full md:w-fit'>My saved</button>
          </div>
          <div className='xl:flex-[1] hidden lg:flex justify-end '>
            <img
              src={`${imageUrl}/homepage/coffee-hand.png`}
              className='h-[280px] w-[315px] xl:h-fit xl:w-auto'
              alt="hand with coffe"/>
          </div>
        </div>
      </div>
    </main>
  );
}
