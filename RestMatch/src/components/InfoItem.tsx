import React from 'react';

interface InfoItemProps {
  title: string;
  description: string;
  buttonText?: string | undefined;
  onClickHandle: any;
}

const InfoItem = (props: InfoItemProps) => {
  const {title, description, buttonText, onClickHandle} = props;
  return (
    <div className='bg-cyan-500 px-8 py-3 pb-10'
         style={{
           backgroundImage: 'url(assets/images/homepage/item-background.png)',
         }}>
      <h3 className='mb-[39px] font-bold'>{title}</h3>
      <p className='text-xl'>{description}</p>
      {buttonText &&
          <button onClick={onClickHandle} className='mt-7 border-2 border-white text-2xl rounded-xl px-5 py-1 font-medium'>
            {buttonText}
          </button>
      }
    </div>
  );
};

export default InfoItem;